using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
//Asem M. Abualrub 
using System.Windows.Forms;

namespace Game_123889_Asem
{


    static class MainClass
    {
        public static MainForm MainForm;

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();

            Application.Run(MainForm);

        }
    }



    public class Player
    {
        public enum Gender
        {
            Male, Female
        }

        public int mAge { set; get; }
        public Image mAvatar { set; get; }
        public Gender mGender { set; get; }
        public string mName { set; get; }

        public int mScore { set; get; }

        public bool isHuman { set; get; }


        public Player()
        {
            mScore = 0;
            isHuman = true;
        }
        public Player(string name, Gender gender, int age, Image avatar)
        {
            mAge = age;
            mAvatar = avatar;
            mGender = gender;
            mName = name;
            mScore = 0;
            isHuman = true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Player temp = (Player)obj;

            if (obj is GoalKeeper && this is Footballer)
                return false;

            if (mName.Equals(temp.mName) && mGender.Equals(temp.mGender))
                return true;
            else
                return false;

        }

        public override string ToString()
        {
            return string.Format("{0}, Age={1}, {2}.", mName, mAge, mGender);
        }

        public void Update(string name, Gender gender, int age, Image avatar)
        {
            mName = name;
            mGender = gender;
            mAge = age;
            mAvatar = avatar;

        }

    }

    public class GoalKeeper : Player, ICloneable
    {

        public int mSpeed { set; get; }
        public bool canMove { set; get; }

        public GoalKeeper(string name, Gender gender, int age, Image avatar) : base(name, gender, age, avatar)
        {
            mSpeed = 8;
            canMove = true;

        }

        public GoalKeeper() : base("Asem", Gender.Male, 17, Properties.Resources.Boy_1)
        {
            mSpeed = 8;
            canMove = true;

        }

        public void Move(bool up, bool down, bool left, bool right, PictureBox label)
        {
            if (isHuman)
            {
                if (canMove)
                {
                    if (up)
                        if (label.Location.Y >= 210)
                            label.Location = new Point(label.Location.X, label.Location.Y - mSpeed);
                    if (down)
                        if (label.Location.Y <= 510)
                            label.Location = new Point(label.Location.X, label.Location.Y + mSpeed);
                    if (left)
                        if (label.Location.X >= 170)
                            label.Location = new Point(label.Location.X - mSpeed, label.Location.Y);
                    if (right)
                        if (label.Location.X <= 275)
                            label.Location = new Point(label.Location.X + mSpeed, label.Location.Y);
                }
            }
        }

        public void CpuMove(PictureBox label)
        {
            if (!isHuman)
                if (canMove)
                {
                    Random r = new Random(new Random().Next(115));

                    int y = r.Next(200, 560) + 35;
                    label.Location = new Point(label.Location.X, y);

                }

        }

        public void defaultPosition(PictureBox label)
        {
            label.Location = new Point(170, 360);
            canMove = true;
        }

        public object Clone()
        {
            GoalKeeper temp = new GoalKeeper(mName, mGender, mAge, mAvatar);

            return temp;
        }
    }

    public class Footballer : Player, ICloneable
    {
        public int numberOfShoots { set; get; }
        public int decreasingX = 0;
        private int decreasingY;
        public int mPower { set; get; }
        public bool ballMove { set; get; }


        public Footballer() : base("Asem", Gender.Male, 17, Properties.Resources.Girl_1)
        {
            numberOfShoots = 5;
            ballMove = true;

        }

        public Footballer(string name, Gender gender, int age, Image avatar) : base(name, gender, age, avatar)
        {
            numberOfShoots = 5;
            ballMove = true;
        }

        public void Move(bool left, bool right, PictureBox label)
        {
            if (isHuman)
            {
                if (right)
                    if (label.Location.X <= 840)
                        label.Location = new Point(label.Location.X + 10, label.Location.Y);
                if (left)
                    if (label.Location.X >= 740)
                        label.Location = new Point(label.Location.X - 10, label.Location.Y);
            }
        }

        public void Kick(Label label, bool hit, bool hole)
        {
            if (hit)
            {
                if (label.Location.Y < 300)
                    label.Location = new Point(label.Location.X + 5, label.Location.Y - 2);
                else
                    label.Location = new Point(label.Location.X + 5, label.Location.Y + 2);
            }

            else
            if (numberOfShoots >= 0 && !hole)
            {
                decreasingX = decreasingY * 2 + 10;

                if (label.Location.Y == 385)
                    label.Location = new Point(label.Location.X - 10, label.Location.Y);
                if (label.Location.Y < 385)
                    label.Location = new Point(label.Location.X - decreasingX, label.Location.Y - decreasingY);

                if (label.Location.Y > 385)
                    label.Location = new Point(label.Location.X - decreasingX, label.Location.Y + decreasingY);

                return;
            }


            if (hole && MainForm.runningGame.Level == 3)
            {
                decreasingX = decreasingY * 2 + 10;

                if (label.Location.Y <= 385)
                    label.Location = new Point(label.Location.X - decreasingX, label.Location.Y + decreasingY);
                else
                    label.Location = new Point(label.Location.X - decreasingX, label.Location.Y - decreasingY);
            }
        }

        public void Direction(bool up, bool down, Label label)
        {
            if (isHuman)
                if (ballMove)
                {
                    if (up)
                    {

                        if (label.Location.Y > 335)

                            label.Location = new Point(label.Location.X, label.Location.Y - 2);
                        DecreasingY(label);


                    }
                    if (down)
                    {
                        if (label.Location.Y < 435)
                            label.Location = new Point(label.Location.X, label.Location.Y + 2);
                        DecreasingY(label);

                    }

                }
        }

        public void CpuDirection(Label label, Timer timer, Label powerBar)
        {
            if (!isHuman)
                if (ballMove)
                {
                    Random r = new Random(new Random().Next(110));

                    int y = r.Next(315, 410) + 25;
                    label.Location = new Point(label.Location.X, y);
                    DecreasingY(label);

                    powerBar.Width = new Random().Next(0, 245);
                    mPower = (int)Math.Floor(powerBar.Width / 50.0);
                    if (timer.Interval > 1)
                        timer.Interval -= mPower;
                    timer.Start();


                }
        }
        //Asem M. Abualrub 
        private void DecreasingY(Label label)
        {
            if (label.Location.Y >= 335 && label.Location.Y < 385)
                decreasingY = (385 - label.Location.Y) / 5;
            else
           if (label.Location.Y > 385 && label.Location.Y <= 435)
                decreasingY = (label.Location.Y - 385) / 5;
        }

        public void DefaultPosition(Label label)
        {
            label.Location = new Point(665, 385);
            ballMove = true;
            if (numberOfShoots <= 0)
                label.Visible = false;
        }

        public void Power(bool s, Label label, Timer timer)
        {
            if (s && numberOfShoots > 0)
            {
                if (label.Width < 250)
                {
                    label.Width += 10;

                    mPower = (int)Math.Floor(label.Width / 100.0);
                    if (timer.Interval > 1)
                        timer.Interval -= mPower;
                }
            }
        }

        public object Clone()
        {
            Footballer temp = new Footballer(mName, mGender, mAge, mAvatar);

            return temp;
        }

    }

    public class Game
    {
        public List<string> History { set; get; }
        public int Level { get; set; }
        public int Goals { get; set; }

        public Footballer Footballer { get; set; }
        public GoalKeeper Keeper { get; set; }
        public DateTime Date { get; set; }

        public TimeSpan Duration { get; set; }

        public Game()
        {
            Level = 1;
            Date = DateTime.Now;
            Goals = 0;
            History = new List<string>();

        }


        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}.", Level, Date, Duration.Seconds);
        }

        public async Task Replay(int level)
        {
            foreach (string es in History)
            {
                MainClass.MainForm.ReplayPause();
                await Task.Delay(5);
                string[] d = es.Split(' ');

                switch (d[0])
                {
                    case "Location":
                        MainClass.MainForm.Controls.Find(d[3], true)[0].Location = new Point(Convert.ToInt32(d[1]), Convert.ToInt32(d[2]));
                        break;
                    case "Text":
                        MainClass.MainForm.Controls.Find(d[2], true)[0].Text = d[1];
						if(d[2] == "LevelLabel"){
                        if (MainClass.MainForm.Controls.Find(d[2], true)[0].Text == 2.ToString())
                        {
                            MainClass.MainForm.Level2();
                        }
                        if (MainClass.MainForm.Controls.Find(d[2], true)[0].Text == 3.ToString())
                        {
                            MainClass.MainForm.Level3();
                        }
						}
                        break;
                    case "Size":
                        MainClass.MainForm.Controls.Find(d[3], true)[0].Height = Convert.ToInt32(d[1]);
                        MainClass.MainForm.Controls.Find(d[3], true)[0].Width = Convert.ToInt32(d[2]);
                        if (d[3] == "KeeperLabel")
                            ((PictureBox) MainClass.MainForm.Controls.Find(d[3], true)[0]).SizeMode=PictureBoxSizeMode.StretchImage;
                        break;
                }
            }

            if (level == 1)
                MainClass.MainForm.ToLevel1();
            await Task.Delay(100);
        }
    }


}
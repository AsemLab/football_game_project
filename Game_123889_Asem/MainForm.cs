using System;
using System.Collections.Generic;
//Asem M. Abualrub 
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_123889_Asem
{
    public partial class MainForm : Form
    {
        SoundPlayer GoalSound;
        SoundPlayer CrowdSound;
        SoundPlayer FailSound;
        SoundPlayer HitPostSound;

        PictureBox DisBall1 = new PictureBox();
        PictureBox DisBall2 = new PictureBox();
        PictureBox DisBoy1 = new PictureBox();
        PictureBox DisBoy2 = new PictureBox();

        PictureBox Hole2 = new PictureBox();
        PictureBox SinkHole = new PictureBox();
        PictureBox KeeperPrize = new PictureBox();
        PictureBox FootballerPrize = new PictureBox();

        static List<string> HistoryLog;

        // Indicates the keys pressing
        bool Key_W = false;
        bool Key_A = false;
        bool Key_S = false;
        bool Key_D = false;

        bool Key_up = false;
        bool Key_down = false;
        bool Key_right = false;
        bool Key_left = false;

        // Result of the shot
        bool hasSaved = false;
        bool hasScore = false;
        bool hasDistracted = false;
        bool Spacebar_Press = false;

        bool hasHit = false;
        bool enterHole = false;
        bool isLocked = false;
        public bool isReplayRunning = false;

        public static GoalKeeper keeper;
        public static Footballer footballer;

        Stopwatch timeOut;
        Stopwatch runTimeWatch;
        PictureBox[] Balls;

        CreatePlayersForm createForm;

        public static Game runningGame;
        public static List<Game> AllGames = new List<Game>();
        public static List<Player> AllProfiles = new List<Player>();


        public MainForm()
        {
            InitializeComponent();

            createForm = new CreatePlayersForm();

            Balls = new PictureBox[] { new PictureBox(), Ball4, Ball3, Ball2, Ball1, Ball6, Ball5, Ball7, Ball8, Ball9 };
            runTimeWatch = new Stopwatch();
            timeOut = new Stopwatch();

            CrowdSound = new SoundPlayer(Properties.Resources.Crowd);
            CrowdSound.PlayLooping();
            GoalSound = new SoundPlayer(Properties.Resources.Goal);
            HitPostSound = new SoundPlayer(Properties.Resources.HitPost);
            FailSound = new SoundPlayer(Properties.Resources.Fail);

        }

        // Activate the game
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!isReplayRunning)
            {
                if (runningGame.Footballer.numberOfShoots > 0)
                {
                    MovingTimer.Enabled = true;
                    if (runningGame.Level >= 2)
                        DistractorsTimer.Enabled = true;
                }

                PlayerScore.Text = runningGame.Footballer.mScore.ToString();
                KeeperScore.Text = runningGame.Keeper.mScore.ToString();
                LevelLabel.Text = runningGame.Level.ToString();
                this.TopMost = true;
            }
        }

        // Create new players
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            createForm.ShowDialog();
            KeeperLabel.Image = runningGame.Keeper.mAvatar;
            FootballerLabel.Image = runningGame.Footballer.mAvatar;
        }

        // Pause the game
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = false;


            MovingTimer.Enabled = false;
            runTimeWatch.Stop();
            timeOut.Stop();
            if (runningGame.Level >= 2)
                DistractorsTimer.Enabled = false;
        }

        // Pause the game for show the replay
        public void ReplayPause()
        {
            isReplayRunning = true;

            MovingTimer.Enabled = false;
            runTimeWatch.Stop();
            timeOut.Stop();
            if (runningGame.Level >= 2)
                DistractorsTimer.Enabled = false;
        }

        private void KeyDown_Click(object sender, KeyEventArgs e)
        {
            // Create Hotkeys
            if (runTimeWatch.IsRunning || MovingTimer.Enabled||runningGame.Footballer.numberOfShoots==0)
            {
                if (e.Control && e.KeyCode == Keys.E)
                    ExitCommand_Click(sender, e);

                if (e.Control && e.KeyCode == Keys.F)
                    NewFootballerCommand_Click(sender, e);

                if (e.Control && e.KeyCode == Keys.G)
                    NewGoalkeeperCommand_Click(sender, e);

                if (e.Control && e.KeyCode == Keys.H)
                    HistoryCommand_Click(sender, e);

                if (e.Control && e.KeyCode == Keys.N)
                    NewGameCommand_Click(sender, e);

                if (e.Control && e.KeyCode == Keys.P)
                    CurrentProfilesCommand_Click(sender, e);

                if (e.Control && e.KeyCode == Keys.R)
                    GameRulesCommand_Click(sender, e);

                if (e.Control && e.KeyCode == Keys.T)
                    StatisticsCommand_Click(sender, e);

                if (e.KeyCode == Keys.Escape)
                    PauseCommand_Click(sender, e);

            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.W)
                Key_W = true;
            if (e.KeyCode == Keys.A)
                Key_A = true;
            if (e.KeyCode == Keys.S)
                Key_S = true;
            if (e.KeyCode == Keys.D)
                Key_D = true;

            if (e.KeyCode == Keys.Up)
                Key_up = true;
            if (e.KeyCode == Keys.Down)
                Key_down = true;
            if (e.KeyCode == Keys.Right)
                Key_right = true;
            if (e.KeyCode == Keys.Left)
                Key_left = true;

            if (e.KeyCode == Keys.Space)
                Spacebar_Press = true;

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.W)
                Key_W = false;
            if (e.KeyCode == Keys.A)
                Key_A = false;
            if (e.KeyCode == Keys.S)
                Key_S = false;
            if (e.KeyCode == Keys.D)
                Key_D = false;

            if (e.KeyCode == Keys.Up)
                Key_up = false;
            if (e.KeyCode == Keys.Down)
                Key_down = false;
            if (e.KeyCode == Keys.Right)
                Key_right = false;
            if (e.KeyCode == Keys.Left)
                Key_left = false;

            if (e.KeyCode == Keys.Space)
                Spacebar_Press = false;
        }

        // Menu commands
        private void PauseCommand_Click(object sender, EventArgs e)
        {
            MovingTimer.Enabled = false;
            MessageBox.Show("The game is paused", "Pause");
        }

        private void NewGameCommand_Click(object sender, EventArgs e)
        {
            runningGame.Duration = runTimeWatch.Elapsed;
            runningGame.History.AddRange(HistoryLog);
            AllGames.Add(runningGame);

            int b = AllProfiles.IndexOf(footballer);
            AllProfiles.RemoveAt(b);
            AllProfiles.Insert(b, footballer);

            if (AllProfiles.Contains(keeper))
            {
                int a = AllProfiles.IndexOf(keeper);
                AllProfiles.RemoveAt(a);
                AllProfiles.Insert(a, keeper);
            }

            HistoryLog = new List<string>();
            runningGame = new Game();

            keeper = new GoalKeeper(keeper.mName, keeper.mGender, keeper.mAge, keeper.mAvatar);
            footballer = new Footballer(footballer.mName, footballer.mGender, footballer.mAge, footballer.mAvatar);
            runningGame.Keeper = keeper;
            runningGame.Footballer = footballer;

            Reset_L1(true);
            MessageBox.Show("A new game was created!");

        }

        private void GameRulesCommand_Click(object sender, EventArgs e)
        {
            new RulesForm().ShowDialog();

        }

        private void CurrentProfilesCommand_Click(object sender, EventArgs e)
        {
            Profiles profiles = new Profiles();
            profiles.ShowDialog();

        }

        private void NewGoalkeeperCommand_Click(object sender, EventArgs e)
        {
            new CreatePlayersForm(1, true).ShowDialog();

            if (AllProfiles.Contains(keeper))
            {
                int a = AllProfiles.IndexOf(keeper);
                AllProfiles.RemoveAt(a);
                AllProfiles.Insert(a, keeper);
            }
            else
            {
                AllProfiles.Add(keeper);
                KeeperLabel.Image = runningGame.Keeper.mAvatar;
            }


        }

        private void NewFootballerCommand_Click(object sender, EventArgs e)
        {
            new CreatePlayersForm(1, false).ShowDialog();

            if (AllProfiles.Contains(footballer))
            {
                int a = AllProfiles.IndexOf(footballer);
                AllProfiles.RemoveAt(a);
                AllProfiles.Insert(a, footballer);
            }
            else
            {
                AllProfiles.Add(footballer);
                FootballerLabel.Image = runningGame.Footballer.mAvatar;
            }
        }

        private void StatisticsCommand_Click(object sender, EventArgs e)
        {
            new StatisticsForm().ShowDialog();
        }

        private void HistoryCommand_Click(object sender, EventArgs e)
        {
            new HistoryForm().ShowDialog();
        }

        private void ExitCommand_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Roll the ball
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (MovingTimer.Enabled)
                if (!isLocked && footballer.isHuman)
                    if (e.KeyCode == Keys.Space)
                    {
                        // if human vs cpu keeper
                        keeper.CpuMove(KeeperLabel);

                        BallTimer.Start();
                        footballer.numberOfShoots--;
                        footballer.ballMove = false;

                        timeOut.Restart();
                        timeOut.Stop();

                        isLocked = true;
                    }
        }

        // Play as human or cpu
        private void CpuKeeper_Click(object sender, EventArgs e)
        {
            keeper.isHuman = false;
        }

        private void HumanKeeper_Click(object sender, EventArgs e)
        {
            keeper.isHuman = true;
        }

        private void CpuFootballer_Click(object sender, EventArgs e)
        {
            footballer.isHuman = false;
        }

        private void HumanFootballer_Click(object sender, EventArgs e)
        {
            footballer.isHuman = true;
        }

        // Start new game or the game
        public static void NewGame()
        {
            // Save the game before start a new one
            if (runningGame != null)
            {
                runningGame.Duration = MainClass.MainForm.runTimeWatch.Elapsed;
                runningGame.History.AddRange(HistoryLog);
                AllGames.Add(runningGame);
            }

            HistoryLog = new List<string>();
            runningGame = new Game();

            keeper = new GoalKeeper(keeper.mName, keeper.mGender, keeper.mAge, keeper.mAvatar);
            footballer = new Footballer(footballer.mName, footballer.mGender, footballer.mAge, footballer.mAvatar);
            runningGame.Keeper = keeper;
            runningGame.Footballer = footballer;

            // Add the players to profiles list
            if (!AllProfiles.Contains(footballer) && !AllProfiles.Contains(keeper))
            {
                AllProfiles.Add(footballer);
                AllProfiles.Add(keeper);

            }

        }

        // Reset game to initial state for Level 1
        public async Task Reset_L1(bool newGame)
        {

            if (newGame && runningGame.Level == 1)
            {
                BallLabel.Visible = true;
                keeper.mScore = 0;
                footballer.mScore = 0;
                footballer.numberOfShoots = 5;

                KeeperScore.Text = keeper.mScore.ToString();
                PlayerScore.Text = footballer.mScore.ToString();

                BallTimer.Stop();

                timeOut.Restart();
                runTimeWatch.Restart();

                for (int i = 0; i < 5; i++)
                    Balls[i].Visible = true;

                if (GoalLabel.Height == 400)
                    ToLevel1();

                KeeperLabel.Image = runningGame.Keeper.mAvatar;
                FootballerLabel.Image = runningGame.Footballer.mAvatar;
            }

            if (!newGame)
            {
                await Task.Delay(500);
                Balls[footballer.numberOfShoots].Visible = false;
            }

            footballer.DefaultPosition(BallLabel);
            keeper.defaultPosition(KeeperLabel);
            Spacebar_Press = false;
            BallLabel.Enabled = true;
            hasHit = false;
            enterHole = false;
            isLocked = false;
            PowerLabel.Width = 0;
            BallTimer.Interval = 51;

            if (footballer.numberOfShoots > 0)
                BallLabel.Visible = true;
            else
                // Game over in level 1
                if (runningGame.Goals < 3 && runningGame.Level == 1)
                MessageBox.Show("Game over");

        }

        // Reset game to initial state for Level 2
        public async Task Reset_L2(bool newGame)
        {
            if (newGame)
            {
                runningGame.Goals = 0;
                Level2();
                BallLabel.Visible = true;
                footballer.numberOfShoots = 7;
                BallTimer.Stop();

                for (int i = 0; i < 7; i++)
                    Balls[i].Visible = true;

                timeOut.Restart();

            }
            enterHole = false;
            DistractorsTimer.Enabled = true;
            await Reset_L1(newGame);

            // Game over in level 2
            if (runningGame.Goals < 4 && footballer.numberOfShoots == 0)
            {
                timeOut.Stop();
                MovingTimer.Enabled = false;
                DistractorsTimer.Enabled = false;
                MessageBox.Show("Game over");
            }
        }

        // Reset game to initial state for Level 3
        public async Task Reset_L3(bool newGame)
        {
            if (newGame)
            {
                runningGame.Goals = 0;
                Level3();
                BallLabel.Visible = true;
                footballer.numberOfShoots = 10;
                BallTimer.Stop();

                for (int i = 0; i < 10; i++)
                    Balls[i].Visible = true;

                timeOut.Restart();

            }

            if (footballer.numberOfShoots != 0)
            {
                DistractorsTimer.Enabled = true;

                Hole2.Location = new Point(new Random().Next(275, 395), new Random().Next(505, 645));
                SinkHole.Location = new Point(new Random().Next(400, 600), new Random().Next(300, 500));
                
                enterHole = false;

                await Reset_L1(newGame);
                await ShowPrizes();
            }
           
        }

        // Reset game depending on game level
        private async void ResetLoader()
        {
            CrowdSound.PlayLooping();

            switch (runningGame.Level)
            {
                case 1:
                    await Reset_L1(false);
                    // To move to level 2
                    if (runningGame.Goals >= 3 && footballer.numberOfShoots == 0)
                    {
                        runningGame.Level = 2;
                        await Reset_L2(true);
                    }
                    break;
                case 2:
                    await Reset_L2(false);
                    // To move to level 3
                    if (runningGame.Goals >= 4 && footballer.numberOfShoots == 0)
                    {
                        runningGame.Level = 3;
                        await Reset_L3(true);
                    }
                    break;
                case 3:
                    await Reset_L3(false);
                    // To end the game
                    if ( footballer.numberOfShoots == 0)
                    {
                        BallTimer.Enabled = false;
                        MovingTimer.Enabled = false;
                        DistractorsTimer.Enabled = false;
                        timeOut.Stop();
                        MessageBox.Show("Game Over!");
                        BallLabel.Visible = false;
                    }
                    break;
            }
        }

        // Timer tick for control in ball movement
        private void BallTimer_tick(object sender, EventArgs e)
        {
            int i = 4;

            while (i > 0)
            {
                // make the ball move inside the pitch boundary
                if (BallLabel.Location.X > 45 && (BallLabel.Location.Y > 140 && BallLabel.Location.Y < 630))
                {
                    hasSaved = false;
                    hasScore = false;
                    hasDistracted = false;

                    footballer.Kick(BallLabel, hasHit, enterHole);

                    if (runningGame.Level >= 2)
                    {   // Ball hit the distractors
                        if (BallLabel.Bounds.IntersectsWith(DisBall1.Bounds) || BallLabel.Bounds.IntersectsWith(DisBall2.Bounds))
                        {
                            keeper.canMove = false;
                            footballer.ballMove = false;
                            Spacebar_Press = false;
                            BallLabel.Enabled = false;
                            isLocked = true;
                            hasDistracted = true;
                            DistractorsTimer.Enabled = false;
                            BallTimer.Enabled = false;
                            timeOut.Stop();

                            break;
                        }
                    }
                    if (runningGame.Level == 3)
                    {
                        // Ball enter hole
                        if (BallLabel.Bounds.IntersectsWith(Hole2.Bounds))
                        {
                            footballer.ballMove = false;
                            Spacebar_Press = false;
                            isLocked = true;
                            enterHole = true;
                            timeOut.Stop();
                        }
                        // Ball enter the sink hole
                        if (BallLabel.Bounds.IntersectsWith(SinkHole.Bounds))
                        {
                            footballer.ballMove = false;
                            BallLabel.Visible = false;
                            Spacebar_Press = false;
                            isLocked = true;
                            BallTimer.Enabled = false;
                            timeOut.Stop();
                            break;
                        }
                    }

                    // Player score a goal
                    if (BallLabel.Bounds.IntersectsWith(GoalLabel.Bounds))
                    {
                        footballer.ballMove = false;
                        Spacebar_Press = false;
                        BallLabel.Enabled = false;
                        isLocked = true;
                        hasScore = true;

                        timeOut.Stop();
                        break;
                    }
                    //Hit the posts
                    if (BallLabel.Bounds.IntersectsWith(upperPost.Bounds) || BallLabel.Bounds.IntersectsWith(lowerPost.Bounds))
                    {
                        keeper.canMove = false;
                        footballer.ballMove = false;
                        Spacebar_Press = false;
                        isLocked = true;
                        hasHit = true;
                        timeOut.Stop();
                        break;
                    }
                    //Keeper catch the ball
                    if (BallLabel.Bounds.IntersectsWith(KeeperLabel.Bounds))
                    {
                        keeper.canMove = false;
                        footballer.ballMove = false;
                        Spacebar_Press = false;
                        BallLabel.Enabled = false;
                        BallTimer.Enabled = false;
                        hasSaved = true;
                        isLocked = true;
                        timeOut.Stop();
                        break;
                    }
                }
                // if the ball go out the pitch boundary
                else
                {
                    BallLabel.Enabled = false;
                    isLocked = true;
                    BallTimer.Stop();
                    timeOut.Stop();

                    if (!hasSaved && !hasScore && !hasHit)
                    {
                        FailSound.PlaySync();
                        break;

                    }
                }

                i--;
            }// end while


            // state after the shot
            if (hasScore && BallTimer.Enabled == false)
            {
                footballer.mScore += 50;
                PlayerScore.Text = footballer.mScore.ToString();
                runningGame.Goals++;
                CrowdSound.Stop();
                GoalSound.PlaySync();
            }
            if (hasSaved)
            {
                keeper.mScore += 50;
                KeeperScore.Text = keeper.mScore.ToString();
                FailSound.PlaySync();
            }

            if (hasDistracted)
            {
                footballer.mScore -= 15;
                PlayerScore.Text = footballer.mScore.ToString();
            }

            // in case the ball stop moving go to next try
            if (BallTimer.Enabled == false)
            {
                KeeperLabel.Height = 100;
                KeeperLabel.SizeMode = PictureBoxSizeMode.Normal;
                BallTimer.Interval = 51;
                ResetLoader();
            }
        }

        // Timer tick for control in [ shoot dirction, keeper, footballer, kick power and prizes ]
        private void MovingTimer_Tick(object sender, EventArgs e)
        {

            keeper.Move(Key_W, Key_S, Key_A, Key_D, KeeperLabel);

            footballer.Move(Key_left, Key_right, FootballerLabel);

            footballer.Direction(Key_up, Key_down, BallLabel);

            TimeOut();

            if (!isLocked)
                footballer.Power(Spacebar_Press, PowerLabel, BallTimer);

            // Display game run time
            if (footballer.numberOfShoots > 0)
            {
                runTimeWatch.Start();
                RunTimeLabel.Text = string.Format("{0:d2}:{1:d2}", runTimeWatch.Elapsed.Minutes, runTimeWatch.Elapsed.Seconds);
            }
            else
                if (runningGame.Goals < 3)
                runTimeWatch.Stop();

            if (runningGame.Level == 3)
            {
                // Control of prizes movement
                if (KeeperPrize.Location.Y < 700)
                {
                    KeeperPrize.Location = new Point(KeeperPrize.Location.X, KeeperPrize.Location.Y + new Random().Next(3, 10));
                }
                if (FootballerPrize.Location.Y < 700)
                {
                    FootballerPrize.Location = new Point(FootballerPrize.Location.X, FootballerPrize.Location.Y + new Random().Next(1, 10));
                }
                // Keeper got a prize
                if (KeeperPrize.Bounds.IntersectsWith(KeeperLabel.Bounds))
                {
                    this.Controls.Remove(KeeperPrize);
                    KeeperLabel.Height = 300;
                    KeeperLabel.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                // Footballer got a prize
                if (FootballerPrize.Bounds.IntersectsWith(FootballerLabel.Bounds))
                {
                    this.Controls.Remove(FootballerPrize);
                    BallTimer.Interval = 1;
                }
            }

        }

        // Display the timeout for the shot and control in cpu footballer
        private void TimeOut()
        {

            if ((footballer.numberOfShoots != 0 && !isLocked) || (runningGame.Goals >= 3))
                timeOut.Start();

            // Diplay the timeout
            int sec;
            if (runningGame.Level < 3)
                sec = 10 - timeOut.Elapsed.Seconds;
            else
                sec = 15 - timeOut.Elapsed.Seconds;

            TimeOutLabel.Text = (sec).ToString();

            // Control in cpu footballer
            if (sec == new Random().Next(2, 8) && !footballer.isHuman)
            {
                // Cpu footballer vs cpu keeper
                if (!keeper.isHuman)
                    keeper.CpuMove(KeeperLabel);

                footballer.CpuDirection(BallLabel, BallTimer, PowerLabel);

                footballer.numberOfShoots--;
                footballer.ballMove = false;
                timeOut.Restart();
                timeOut.Stop();
            }

            // Timeout finish
            if (sec <= 0)
            {
                footballer.numberOfShoots--;
                keeper.mScore += 35;
                KeeperScore.Text = keeper.mScore.ToString();
                timeOut.Reset();
                if (footballer.numberOfShoots > 0)
                    Balls[footballer.numberOfShoots].Visible = false;

                // If no more shots is allowed after timeout finish
                if (footballer.numberOfShoots == 0)
                {
                    BallLabel.Visible = false;
                    timeOut.Stop();

                    if (DistractorsTimer.Enabled || runningGame.Level == 1)
                        ResetLoader();
                }


            }

        }

        // Start level 2
        public void Level2()
        {

            LevelLabel.Text = runningGame.Level.ToString();

            GoalLabel.Height += 100;
            GoalLabel.Location = new Point(GoalLabel.Location.X, GoalLabel.Location.Y - 50);

            MaskGoal.Height += 100;
            MaskGoal.Image = Properties.Resources.Wide_net;
            MaskGoal.Location = new Point(MaskGoal.Location.X, MaskGoal.Location.Y - 50);

            upperPost.Location = new Point(upperPost.Location.X, upperPost.Location.Y - 50);
            lowerPost.Location = new Point(lowerPost.Location.X, lowerPost.Location.Y + 50);

            keeper.mSpeed = 12;

            DisBoy1.Size = new Size(100, 100);
            DisBoy1.Location = new Point(425, 90);
            DisBoy1.BackColor = Color.Transparent;
            DisBoy1.Image = Properties.Resources.Bad_boy_1;

            DisBoy2.Size = new Size(100, 100);
            DisBoy2.Location = new Point(545, 90);
            DisBoy2.BackColor = Color.Transparent;
            DisBoy2.Image = Properties.Resources.Bad_boy_2;

            DisBall1.Name = "DisBall1";
            DisBall1.Size = new Size(50, 50);
            DisBall1.Location = new Point(435, 140);
            DisBall1.BackColor = Color.Transparent;
            DisBall1.Image = Properties.Resources.Dis_ball;
            DisBall1.LocationChanged += new EventHandler(Control_LocationChanged);

            DisBall2.Name = "DisBall2";
            DisBall2.Size = new Size(50, 50);
            DisBall2.Location = new Point(555, 140);
            DisBall2.BackColor = Color.Transparent;
            DisBall2.Image = Properties.Resources.Dis_ball;
            DisBall2.LocationChanged += new EventHandler(Control_LocationChanged);

            Controls.Add(DisBoy1);
            Controls.Add(DisBoy2);
            Controls.Add(DisBall1);
            Controls.Add(DisBall2);

            DisBall1.BringToFront();
            DisBall2.BringToFront();
            DisBoy1.BringToFront();
            DisBoy2.BringToFront();


        }

        // Start level 3
        public void Level3()
        {
            LevelLabel.Text = runningGame.Level.ToString();

            Hole2.Name = "Hole2";
            Hole2.Size = new Size(50, 50);
            Hole2.Location = new Point(new Random().Next(310, 395), new Random().Next(505, 645));
            Hole2.Image = Properties.Resources.To_up;
            Hole2.BackColor = Color.Transparent;
            Hole2.LocationChanged += new EventHandler(Control_LocationChanged);

            SinkHole.Name = "SinkHole";
            SinkHole.Size = new Size(50, 50);
            SinkHole.Location = new Point(new Random().Next(400, 600), new Random().Next(300, 500));
            SinkHole.Image = Properties.Resources.Sink;
            SinkHole.BackColor = Color.Transparent;
            SinkHole.LocationChanged += new EventHandler(Control_LocationChanged);

            Controls.Add(Hole2);
            Controls.Add(SinkHole);

            SinkHole.BringToFront();

            DisBall1.BringToFront();
            DisBall2.BringToFront();

        }

        // Back to level 1
        public void ToLevel1()
        {
            LevelLabel.Text = runningGame.Level.ToString();

            GoalLabel.Height = 300;
            GoalLabel.Location = new Point(50, 260);

            MaskGoal.Height = 340;
            MaskGoal.Image = Properties.Resources.Net;
            MaskGoal.Location = new Point(50, 240);

            upperPost.Location = new Point(150, 240);
            lowerPost.Location = new Point(150, 560);

            keeper.mSpeed = 8;
            KeeperLabel.Height = 100;
            footballer.decreasingX = 0;

            this.Controls.Remove(DisBall1);
            this.Controls.Remove(DisBall2);
            this.Controls.Remove(DisBoy1);
            this.Controls.Remove(DisBoy2);

            DistractorsTimer.Enabled = false;

            Ball5.Visible = false;
            Ball6.Visible = false;

            Ball7.Visible = false;
            Ball8.Visible = false;
            Ball9.Visible = false;

            Controls.Remove(Hole2);
            Controls.Remove(SinkHole);
            Controls.Remove(KeeperPrize);
            Controls.Remove(FootballerPrize);

        }

        // Control the distractors ball
        private void DistractorsTimer_Tick(object sender, EventArgs e)
        {
            if (DisBall1.Location.Y < 600)
                DisBall1.Location = new Point(DisBall1.Location.X, DisBall1.Location.Y + new Random().Next(5, 15));
            else
                DisBall1.Location = new Point(435, 140);

            if (DisBall2.Location.Y < 580)
                DisBall2.Location = new Point(DisBall2.Location.X, DisBall2.Location.Y + new Random().Next(3, 12));
            else
                DisBall2.Location = new Point(555, 140);

        }

        public async Task ShowPrizes()
        {
            await Task.Delay(new Random().Next(1000, 10001));

            KeeperPrize.Location = new Point(new Random().Next(275, 375), 150);
            KeeperPrize.Size = new Size(60, 50);
            KeeperPrize.BackColor = Color.Transparent;
            KeeperPrize.Image = Properties.Resources.Prizes;
            KeeperPrize.Visible = true;

            await Task.Delay(new Random().Next(4000, 11001));
            FootballerPrize.Location = new Point(new Random().Next(740, 940), 150);
            FootballerPrize.Size = new Size(60, 50);
            FootballerPrize.BackColor = Color.Transparent;
            FootballerPrize.Image = Properties.Resources.Prizes;
            FootballerPrize.Visible = true;

            Controls.Add(KeeperPrize);
            Controls.Add(FootballerPrize);

            KeeperPrize.BringToFront();
            FootballerPrize.BringToFront();
            // For remove the prizes
            if (runningGame.Level == 1)
            {
                KeeperPrize.Visible = false;
                FootballerPrize.Visible = false;
            }
        }

        private void BallLabel_EnabledChanged(object sender, EventArgs e)
        {
            if (hasHit && !BallLabel.Enabled && (BallLabel.Location.Y <= 140 || BallLabel.Location.Y >= 630))
            {
                HitPostSound.PlaySync();
            }

        }

        private void Control_LocationChanged(object sender, EventArgs e)
        {
            if (runTimeWatch.IsRunning)
            {
                Control control = sender as Control;
                HistoryLog.Add(string.Format("{0} {1} {2} {3}", "Location", control.Location.X, control.Location.Y, control.Name));
            }
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            if (runTimeWatch.IsRunning)
            {
                Label send = sender as Label;
                HistoryLog.Add(string.Format("{0} {1} {2}", "Text", send.Text, send.Name));
            }
        }

        private void Control_SizeChanged(object sender, EventArgs e)
        {
            if (runTimeWatch.IsRunning)
            {
                Control send = sender as Control;
                HistoryLog.Add(string.Format("{0} {1} {2} {3}", "Size", send.Height, send.Width, send.Name));
            }
        }


    }
}

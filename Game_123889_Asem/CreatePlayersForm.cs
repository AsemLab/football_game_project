using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_123889_Asem
{
    public partial class CreatePlayersForm : Form
    {
        int allow;

        public CreatePlayersForm()
        {
            InitializeComponent();
            allow = 2;
            SaveButton.Text = string.Format("Save ({0})", allow);

        }

        // Form constructor for create new players
        public CreatePlayersForm(int a, bool isKeeper)
        {
            InitializeComponent();
            allow = a;
            SaveButton.Text = string.Format("Save ({0})", allow);
            this.Text = "Create / Update profile";

            if (isKeeper)
            {
                FootballerButton.Visible = false;
                KeeperButton.Checked = true;
            }
            else
            {
                KeeperButton.Visible = false;
                FootballerButton.Checked = true;
            }

        }

        // Save the data
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (allow > 0)
            {
                string name = NameBox.Text.ToString();

                Player.Gender gender;

                if (FemaleButton.Checked)
                    gender = Player.Gender.Female;
                else
                    gender = Player.Gender.Male;

                int age = (int)(AgeBox.Value);

                Image ava;
                if (Avatar1.Checked)
                    ava = Properties.Resources.Girl_1;
                else
                if (Avatar2.Checked)
                    ava = Properties.Resources.Girl_2;
                else
                if (Avatar3.Checked)
                    ava = Properties.Resources.Boy_1;
                else
                    ava = Properties.Resources.Boy_2;


                if (FootballerButton.Checked)
                {
                    ava.RotateFlip(RotateFlipType.Rotate180FlipY);

                    Footballer temp = new Footballer(name, gender, age, ava);

                    if (MainForm.footballer != null)
                    {
                        if (MainForm.footballer.Equals(temp))
                        {
                            MainForm.footballer.Update(name, gender, age, ava);
                        }
                        else
                        {
                            MainForm.footballer = temp;
                        }
                    }
                    else
                    {
                        MainForm.footballer = temp;
                    }

                    FootballerButton.Enabled = false;
                    KeeperButton.Checked = true;

                }
                else
                {
                    GoalKeeper temp = new GoalKeeper(name, gender, age, ava);

                    if (MainForm.keeper != null)
                    {
                        if (MainForm.keeper.Equals(temp))
                        {
                            MainForm.keeper.Update(name, gender, age, ava);
                        }
                        else
                        {
                            MainForm.keeper = temp;
                        }
                    }
                    else
                    {
                        MainForm.keeper = temp;
                    }

                    KeeperButton.Enabled = false;
                    FootballerButton.Checked = true;

                }

                allow--;
                SaveButton.Text = string.Format("Save ({0})", allow);

                if (allow == 0)
                {

                    MainClass.MainForm.Reset_L1(true);

                    MainForm.NewGame();


                    this.Close();
                }
            }
            
        }
        // Close the form
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (allow == 0)
                this.Close();
        }


    }
}

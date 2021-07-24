using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Game_123889_Asem
{
    public partial class Profiles : Form
    {
        public Profiles()
        {
            InitializeComponent();
        }

        private void Profiles_Load(object sender, EventArgs e)
        {
            string name1 = MainForm.runningGame.Keeper.mName;

            var scores = from game in MainForm.AllGames
                         where (name1.Equals(game.Keeper.mName))
                         select game.Keeper.mScore;

            KeeperImage.Image = MainForm.runningGame.Keeper.mAvatar;
            KeeperName.Text = name1;
            KeeperAge.Text += MainForm.runningGame.Keeper.mAge.ToString();
            KeeperScores.Text += scores.Sum();
            KeeperGames.Text += scores.Count();


            string name2 = MainForm.runningGame.Footballer.mName;

            var scores2 = from game in MainForm.AllGames
                          where (name2.Equals( game.Footballer.mName))
                          select game.Footballer.mScore;

            PlayerImage.Image = MainForm.runningGame.Footballer.mAvatar;
            PlayerName.Text = name2;
            PlayerAge.Text += MainForm.runningGame.Footballer.mAge.ToString();
            PlayerScores.Text += scores2.Sum();
            PlayerGames.Text += scores2.Count();
        }

       
    }
}

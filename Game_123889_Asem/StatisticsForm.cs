using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Game_123889_Asem
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            if(MainForm.AllGames.Count==0)
            {
                MessageBox.Show("No games have end yet !");
                return;
            }

            var KeeperScore = from v in MainForm.AllGames
                              select v.Keeper.mScore ;

            var PlayerScore = from v in MainForm.AllGames
                              select v.Footballer.mScore;

            var duration = from v in MainForm.AllGames
                           select Math.Floor(v.Duration.TotalSeconds);

            this.dataGridView1.Rows.Add("# of Games", MainForm.AllGames.Count);
            this.dataGridView1.Rows.Add("# of Profiles", MainForm.AllProfiles.Count);
            
            dataGridView1.Rows.Add("Highest score", Math.Max(KeeperScore.Max(),PlayerScore.Max()));
            dataGridView1.Rows.Add("Lowest score", Math.Min(KeeperScore.Min(), PlayerScore.Min()));

            dataGridView1.Rows.Add("Maximum duration", duration.Max());
            dataGridView1.Rows.Add("Minimum duration", duration.Min());

            dataGridView1.Rows.Add("Totol duration", duration.Sum() + " S");

        }
    }
}

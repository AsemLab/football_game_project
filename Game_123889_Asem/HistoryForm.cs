using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Game_123889_Asem
{
    public partial class HistoryForm : Form
    {
        PictureBox picture = new PictureBox();
       

        public HistoryForm()
        {
            InitializeComponent();
            picture.Image = Properties.Resources.Replay;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.BackColor = Color.Transparent;
            picture.Location = new Point(690, 160);
            picture.Size = new Size(250, 50);
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (MainForm.AllGames.Count == 0)
            {
                DialogResult result=MessageBox.Show("No games have end yet !","Games history",MessageBoxButtons.OK);
                if(result==DialogResult.OK)
                this.Close();
            }
            var QueryGames = from game in MainForm.AllGames
                             select game;

            foreach (var element in QueryGames)
            {

                HistoryDataView.Rows.Add(element.Footballer.mName + " & " + element.Keeper.mName+"     (R)",
                                element.Date.ToShortDateString(),
                                Math.Floor(element.Duration.TotalSeconds) + " S",
                                element.Footballer.mScore,
                                element.Keeper.mScore);
            }
        }

        private async void HistoryDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.Hide();
                MainClass.MainForm.Controls.Add(picture);
                await MainForm.AllGames[e.RowIndex].Replay(MainForm.runningGame.Level);

            }
            MainClass.MainForm.Controls.Remove(picture);
            this.Show();
        }

        private void HistoryForm_Activated(object sender, EventArgs e)
        {
            MainClass.MainForm.isReplayRunning = false;
        }
    }
}

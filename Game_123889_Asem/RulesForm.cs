using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_123889_Asem
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            label1.Text = Properties.Resources.Game_rules.ToString();
        }
    }
}

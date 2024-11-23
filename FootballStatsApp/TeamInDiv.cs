using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballStatsApp
{
    public partial class TeamInDiv : UserControl
    {
        public TeamInDiv(string name, int rank, int wins, int losses)
        {
            InitializeComponent();
            UxRankValLable.Text = rank.ToString();
            UxTeamNameLabel.Text = name;
        }
    }
}

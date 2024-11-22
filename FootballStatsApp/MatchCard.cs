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
    public partial class MatchCard : UserControl
    {
        public MatchCard(string date, string home, string away, string winner)
        {
            UxMatchDateBtn.Text = date;
            UxHomeTeamLabel.Text = home;
            UxAwayTeamLabel.Text = away;
            UxWinningTeamLabel.Text = winner;
            
            InitializeComponent();
        }
    }
}

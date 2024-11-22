using Backend;
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
        public MatchCard(string date, string home, string away, 
            string winner, string homepts, string awaypts, string stadium)
        {
                      
            InitializeComponent();
            UxDateLabel.Text = date;
            UxHomeTeamLabel.Text = home;
            UxHomePointsLabel.Text = homepts;
            UxAwayTeamLabel.Text = away;
            UxAwayPointsLabel.Text = awaypts;
            WinLbl.Text = winner;
            UxStadiumNameLabel.Text = stadium;
        }
    }
}

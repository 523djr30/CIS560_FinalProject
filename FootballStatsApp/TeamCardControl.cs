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
    public partial class TeamCardControl : UserControl
    {
        public TeamCardControl(TeamCardModel teamData)
        {
            InitializeComponent();
            UxCityLocLabel.Text = teamData.city;
            UxDivisionNameLabel.Text = teamData.divisionName;
            UxNumLossLabel.Text = teamData.numLoss.ToString();
            UxNumWinLabel.Text = teamData.numWins.ToString();
            UxStadiumLabel.Text = teamData.stadium;
            //UxStartDateLabel.Text = teamData.startDate;
            UxTeamNameLabel.Text = teamData.name;
        }

        private void UxLossesFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

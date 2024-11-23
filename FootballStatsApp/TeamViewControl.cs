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
    public partial class TeamViewControl : UserControl
    {
        private List<Control> AllTeamCards;
        private List<Control> CurrentTeamCards;
        public TeamViewControl()
        {
            InitializeComponent();
            PopulateComboBox();
            InitialPopulateTeams();
        }

        /// <summary>
        /// Fills the search box with teams in the database.
        /// </summary>
        private void PopulateComboBox()
        {
            Table? result = Backend.DatabaseManage.QueryFileText("",
                "GetAllTeamNames");
            foreach (Row team in result)
            {
                UxTeamComboBox.Items.Add(team.GetItem<string>("TeamName"));
            }
        }

        /// <summary>
        /// Performs a forced populate with all teams in the database to initialize the view and provide an alternative to bad input.
        /// </summary>
        private void InitialPopulateTeams()
        {
            Table? teamsInfo = Backend.DatabaseManage.QueryFileText("", "TeamCardQuery");
            List<TeamCardModel> infoCards = [];
            foreach (Row row in teamsInfo)
            {
                //Table? _roster = Backend.DatabaseManage.QueryFileText("DECLARE @TeamId INT = " + row.GetItem<int>("TeamId")+ ";\n", "TeamRoster");
                //Table? _matches = Backend.DatabaseManage.QueryFileText("DECLARE @TeamId INT = " + row.GetItem<int>("TeamId") + ";\n", "TeamMatches");
                TeamCardModel infoCard = new TeamCardModel()
                {
                    name = row.GetItem<string>("TeamName"),
                    city = row.GetItem<string>("City"),
                    //startDate = row.GetItem<string>("Name"),
                    stadium = row.GetItem<string>("StadiumName"),
                    divisionName = row.GetItem<string>("DivisionName"),
                    numWins = row.GetItem<int>("Wins"),
                    numLoss = row.GetItem<int>("Losses")/*,

                    roster = _roster,
                    matches = _matches*/
                };
                infoCards.Add(infoCard);
            }

            foreach (TeamCardModel infocard in infoCards)
            {
                UxTeamsFlowPanel.Controls.Add(new TeamCardControl(infocard));
            }

        }

        /// <summary>
        /// Fills in the team cards based on the search criteria.
        /// </summary>
        /// <param name="teamName">The name of the team given by the combo box by the user.</param>
        private void PopulateTeams(string teamName)
        {
            if (teamName == null || teamName == "")
            {
                InitialPopulateTeams();
                return;
            }
            else
            {
                Table? teamsInfo = Backend.DatabaseManage.QueryFileText("DECLARE @TeamName NVARCHAR(32) = N'"+teamName+"';\n", "SingleTeamCardQ");
                UxTeamsFlowPanel.Controls.Clear();
                if (teamsInfo is null)
                {
                    InitialPopulateTeams();
                    return;
                };
                Row row = teamsInfo[0];
                TeamCardModel infoCard = new TeamCardModel()
                {
                    name = row.GetItem<string>("TeamName"),
                    city = row.GetItem<string>("City"),
                    //startDate = row.GetItem<string>("Name"),
                    stadium = row.GetItem<string>("StadiumName"),
                    divisionName = row.GetItem<string>("DivisionName"),
                    numWins = row.GetItem<int>("Wins"),
                    numLoss = row.GetItem<int>("Losses")/*,

                    roster = _roster,
                    matches = _matches*/
                };
                if (infoCard is null)
                {
                    InitialPopulateTeams();
                    return;
                };
                UxTeamsFlowPanel.Controls.Add(new TeamCardControl(infoCard));
                
            }

        }

        public void AddTeam()
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UxSearchBtn_Click(object sender, EventArgs e)
        {
            PopulateTeams(UxTeamComboBox.Text);
        }
    }
}

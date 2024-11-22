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

        }

        /// <summary>
        /// Fills in the team cards based on the search criteria.
        /// </summary>
        /// <param name="teamName">The name of the team given by the combo box by the user.</param>
        private void PopulateTeams(string teamName)
        {
            if (teamName == null || teamName == ""){
                InitialPopulateTeams();
                return;
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
    }
}

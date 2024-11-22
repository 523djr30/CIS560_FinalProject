using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace FootballStatsApp
{
    public partial class MatchesViewControl : UserControl
    {
        public MatchesViewControl()
        {
            InitializeComponent();
        }

        public static string Sanitize(string s)
        {
            return s.Replace('\'', ' ').Replace('\"', ' ');
        }

        private void UxSearchBtn_Click(object sender, EventArgs e)
        {
            string Team1 = Team1Box.Text, Team2 = Team2Box.Text;

            UxPlayersListBox.Items.Clear();
            Table? t = Backend.DatabaseManage.QueryFileText("Declare @TeamName1 NVarChar(32) = N'" + Team1 + "';\n" +
                                                            "Declare @TeamName2 NVarChar(32) = N'" + Team2 + "';",
                "MatchStats");
            foreach(Row row in t)
            {
                UxMatchesResultsFlowPanel.Controls.Add(
                    new MatchCard(
                        row.GetItem<string>("TeamName"),
                        row.GetItem<string>("Wins"),
                        row.GetItem<string>("Losses"),
                        row.GetItem<string>("WinningTeam")
                        )
                    );
            }
            
            Update();
            //StadiumName, MatchDate AS Date, HomeTeamName, HomeTeamPoints, AwayTeamName, AwayTeamPoints
            // Table? t2 = Backend.DatabaseManage.QueryText("Select p.PlayerId from Football.Player p where p.FirstName=N'"+FirstName+"' and p.LastName=N'"+LastName+'\'');
            if (t != null)
            {
                DatabaseManage.PrintTable(t);

                UxPlayersListBox.Items.Add(t.GetHeaderText());
                foreach (Row r in t)
                {
                    UxPlayersListBox.Items.Add(r.ToString());

                }
            }




        }


        private void UxPlayersListBox_DataContextChanged(object sender, EventArgs e)
        {
        }

        private void UxSearchTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void UxPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
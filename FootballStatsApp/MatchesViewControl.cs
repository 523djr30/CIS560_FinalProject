using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            Table? t = Backend.DatabaseManage.QueryFileText("Declare @TeamName1 NVarChar(32) = N'" + Team1 + "';\n" +
                                                            "Declare @TeamName2 NVarChar(32) = N'" + Team2 + "';",
                "MatchStats");


            UxMatchesResultsFlowPanel.SuspendLayout();
            // populate panel with controls
            UxHeaderPanel.Controls.Add(
                new MatchCard(
                        "Date",
                        "Home Team",
                        "Away Team",
                        "Winning Team",
                        "Home Team Points",
                        "Away Team Points",
                        "Stadium"
                    )
                );
            
            foreach (Row row in t)
            {
                /*MessageBox.Show(row.GetItem<DateTimeOffset>("Date").ToString("d") +
                        row.GetItem<string>("HomeTeamName") +
                        row.GetItem<string>("AwayTeamName") +
                        row.GetItem<string>("WinningTeamName") +
                        row.GetItem<int>("HomeTeamPoints").ToString() +
                        row.GetItem<int>("AwayTeamPoints").ToString(),
                        row.GetItem<string>("StadiumName"));*/
                
                UxMatchesResultsFlowPanel.Controls.Add(
                new MatchCard(
                        row.GetItem<DateTimeOffset>("Date").ToString("d"),
                        row.GetItem<string>("HomeTeamName"),
                        row.GetItem<string>("AwayTeamName"),
                        row.GetItem<string>("WinningTeamName"),
                        row.GetItem<int>("HomeTeamPoints").ToString(),
                        row.GetItem<int>("AwayTeamPoints").ToString(),
                        row.GetItem<string>("StadiumName")
                        )
                    );
                UxMatchesResultsFlowPanel.ResumeLayout(true);
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
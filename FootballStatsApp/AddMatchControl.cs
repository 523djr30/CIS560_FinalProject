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
    public partial class AddMatchControl : UserControl
    {
        public AddMatchControl()
        {
            InitializeComponent();
        }

        public static string Sanitize(string s)
        {
            return s.Replace('\'', ' ').Replace('\"', ' ');
        }

        private void UxSearchBtn_Click(object sender, EventArgs e)
        {
            string date = DateBox.Text;
            string HomeTeam = HomeBox.Text;
            string AwayTeam = AwayBox.Text;

            try
            {
                DatabaseManage.RunDmlText("Declare @MatchDate DateTimeOffset = '" + date + "';\n" +
                                          "Declare @TeamName1 NVarChar(32) = N'" + HomeTeam + "';\n" +
                                          "Declare @TeamName2 NVarChar(32) = N'" + AwayTeam + "';\n" +
                                          "Insert into Football.Match(Date,StadiumId,HomeTeamId,AwayTeamId)\n" +
                                          "Select @MatchDate,s.StadiumId,ht.TeamId,at.TeamId from Football.Team ht\n" +
                                          "inner join Football.Team at on at.Name=@TeamName2\n" +
                                          "inner join Football.Stadium s on s.TeamID=ht.TeamId\n" +
                                          "where ht.Name=@TeamName1");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void UxPlayersListBox_DataContextChanged(object sender, EventArgs e)
        {
        }

        private void UxSearchTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
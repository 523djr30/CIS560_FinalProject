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
    public partial class PlayerTeamJoinControl : UserControl
    {
        public PlayerTeamJoinControl()
        {
            InitializeComponent();
        }

        public static string Sanitize(string s)
        {
            return s.Replace('\'', ' ').Replace('\"', ' ');
        }

        private void UxSearchBtn_Click(object sender, EventArgs e)
        {
            int PlayerId;
            string TeamName =TeamNameBox.Text;

            if (int.TryParse(PlayerIdBox.Text, out PlayerId))
            {
                DatabaseManage.RunDmlFileWithValueTable("PlayerId,TeamName,StartDate,EndDate", [[PlayerId,TeamName,'!'+JoinDateTextBox.Text,null]],
                    "PopulatePlayerTeamMembership");
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

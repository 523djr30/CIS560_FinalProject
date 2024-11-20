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
    public partial class DivStandControl : UserControl
    {
        private string DivisionName;

        /// <summary>
        /// Control for displaying data for one division.
        /// </summary>
        /// <param name="DivName">Name of the division teams are in.</param>
        public DivStandControl(string DivName)
        {
            DivisionName = DivName;
            UxDivNameLabel.Text = DivisionName + " Standings";

            InitializeComponent();
        }
    }
}

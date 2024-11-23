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
    public partial class SingleDivControl : UserControl
    {
        public SingleDivControl(string divisionName, List<Control> controls)
        {
            InitializeComponent();
            UxDivisionTitle.Text = divisionName;
            PopulateControls(controls);
        }

        private void PopulateControls(List<Control> controls)
        {
            foreach(Control control in controls)
            {
                UxTeamsFlowPanel.Controls.Add(control);
            }
        }
    }
}

using System.Media;

namespace FootballStatsApp
{
    public partial class LandingView : Form
    {
        public LandingView()
        {
            InitializeComponent();
            OpenHome();
        }
        private void OpenHome()
        {
            UxLandingTextControl.Visible = true;
            UxBothDivControl.Visible = false;
        }
        private void OpenBothDivsView()
        {
            UxLandingTextControl.Visible = false;
            UxBothDivControl.Visible = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void standingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBothDivsView();
        }

        private void LandingView_Load(Object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHome();
        }
    }
}

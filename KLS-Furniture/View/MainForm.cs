using System;
using System.Windows.Forms;

namespace KLS_Furniture
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Link navigation events to correct form initialization
            navUserControl1.MemberManagementClicked += Nav_MemberManagementClicked;
            navUserControl1.FurnitureRentalClicked += Nav_FurnitureRentalClicked;
            navUserControl1.ReturnsClicked += NavUserControl1_ReturnsClicked;
            navUserControl1.MemberHistoryClicked += Nav_MemberHistoryClicked;
            navUserControl1.AdminReportsClicked += Nav_AdminReportsClicked;

            //Set first tab as active
            navUserControl1.SetActiveTab("membermanagement");
            //Will call Member Management form as starting form
        }

        private void NavUserControl1_AdminReportsClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NavUserControl1_ReturnsClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Nav_MemberManagementClicked(object sender, EventArgs e)
        {
            //Will load form
        }

        private void Nav_FurnitureRentalClicked(object sender, EventArgs e)
        {
            //Will load form
        }

        private void Nav_ReturnClicked(object sender, EventArgs e)
        {
            //Will load form
        }

        private void Nav_MemberHistoryClicked(object sender, EventArgs e)
        {
            //Will load form
        }

        private void Nav_AdminReportsClicked(object sender, EventArgs e)
        {
            //Will load form
        }
    }
}

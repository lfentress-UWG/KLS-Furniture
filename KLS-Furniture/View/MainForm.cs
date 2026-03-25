using KLS_Furniture.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KLS_Furniture
{
    /// <summary>
    /// Class for Main Form of application that displays Navigation and Content
    /// </summary>
    public partial class MainForm : Form
    {
        //Creates instance of user controls to be used in Content Panel
        private readonly MemberManageUserControl memberManageUserControl = new MemberManageUserControl();

        private UserControl currentScreen;

        /// <summary>
        /// Constructor for MainForm class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Add user controls to content panel
            this.ContentPanel.Controls.Add(memberManageUserControl);

            //Will need to hide additional panels when added
            foreach (Control control in ContentPanel.Controls)
            {
                control.Visible = false;
            }

            // Link navigation events to correct form initialization
            navUserControl1.MemberManagementClicked += Nav_MemberManagementClicked;
            navUserControl1.FurnitureRentalClicked += Nav_FurnitureRentalClicked;
            navUserControl1.ReturnsClicked += Nav_ReturnClicked;
            navUserControl1.MemberHistoryClicked += Nav_MemberHistoryClicked;
            navUserControl1.AdminReportsClicked += Nav_AdminReportsClicked;

            //Set first tab as active
            navUserControl1.SetActiveTab("membermanagement");
            //Calls Member Management as starting content
            this.ShowContent(memberManageUserControl);
        }

        //Updates Content Panel to selected screen
        private void ShowContent(UserControl selection)
        {
            if (currentScreen != null)
            {
                currentScreen.Visible = false;
            }

            selection.Visible = true;
            selection.BringToFront();
            currentScreen = selection;
        }

        private void Nav_MemberManagementClicked(object sender, EventArgs e)
        {
            navUserControl1.SetActiveTab("membermanagement");
            this.ShowContent(memberManageUserControl);
        }

        private void Nav_FurnitureRentalClicked(object sender, EventArgs e)
        {
            navUserControl1.SetActiveTab("furniturerental");
            // Todo: Update with correct user control
            //this.ShowContent(); 
        }

        private void Nav_ReturnClicked(object sender, EventArgs e)
        {
            navUserControl1.SetActiveTab("returns");
            // Todo: Update with correct user control
            //this.ShowContent();
        }

        private void Nav_MemberHistoryClicked(object sender, EventArgs e)
        {
            navUserControl1.SetActiveTab("memberhistory");
            // Todo: Update with correct user control
            //this.ShowContent();
        }

        private void Nav_AdminReportsClicked(object sender, EventArgs e)
        {
            navUserControl1.SetActiveTab("adminreports");
            // Todo: Update with correct user control
            //this.ShowContent();
        }
    }
}

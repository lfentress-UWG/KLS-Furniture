using KLS_Furniture.UserControls;
using KLS_Furniture.View;
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

        private readonly LoginForm _loginForm;
        private bool _isLoggingOut = false;

        /// <summary>
        /// Constructor for MainForm class
        /// </summary>
        public MainForm(LoginForm loginForm = null)
        {
            InitializeComponent();
            _loginForm = loginForm;

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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                    "KLS Furniture - Logout",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            _isLoggingOut = true;
            this.Close();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_isLoggingOut)
            {
                _isLoggingOut = false;
                base.OnFormClosing(e);
                return;
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Do you want to return to login? \nSelect No to close app.",
                                             "Exit", MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (result == DialogResult.No)
                {
                    Application.Exit();
                    return;
                }
            }
            base.OnFormClosing(e);
        }
    }
}

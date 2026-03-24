using KLS_Furniture.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace KLS_Furniture.UserControls
{
    public partial class MemberDetailsUserControl : UserControl
    {
        public MemberDetailsUserControl()
        {
            InitializeComponent();
            this.DisableAllFields();
            this.PopulateStateCombo();
            this.PopulateGenderCombo();
            
        }
        #region
        //Button response functions
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            this.ClearLabels();
            this.ClearInputs();
            this.EnableAllFields();
        }
        private void CancelMemberButton_Click(object sender, EventArgs e)
        {
            this.ClearLabels();
            this.ClearInputs();
            this.DisableAllFields();
        }
        #endregion

        #region
        //Combobox population functions
        private void PopulateStateCombo() 
        {
            this.StateComboBox.DataSource = US_States.GetAll();
            this.StateComboBox.DisplayMember = "Name";
            this.StateComboBox.ValueMember = "Abbreviation";
            this.StateComboBox.SelectedIndex = -1;
        }

        private void PopulateGenderCombo()
        {
            this.GenderComboBox.DataSource = new[]
                {
                    new { Option = "Male",        Value = "M" },
                    new { Option = "Female",      Value = "F" },
                    new { Option = "Unspecified", Value = "U" }
                };
            this.GenderComboBox.DisplayMember = "Option";
            this.GenderComboBox.ValueMember = "Value";
            this.GenderComboBox.SelectedIndex = -1;
        }

        #endregion

        #region
        //Helper functions
        private void EnableAllFields()
        {
            this.FirstNameTextBox.Enabled = true;
            this.LastNameTextBox.Enabled = true;
            this.PhoneTextBox.Enabled = true;
            this.DOBTextBox.Enabled = true;
            this.AddressTextBox.Enabled = true;
            this.ZipTextBox.Enabled = true;
            this.GenderComboBox.Enabled = true;
            this.StateComboBox.Enabled = true;
        }

        private void DisableAllFields()
        {
            this.FirstNameTextBox.Enabled = false;
            this.LastNameTextBox.Enabled = false;
            this.PhoneTextBox.Enabled = false;
            this.DOBTextBox.Enabled = false;
            this.AddressTextBox.Enabled = false;
            this.ZipTextBox.Enabled = false;
            this.GenderComboBox.Enabled = false;
            this.StateComboBox.Enabled = false;
        }

        private void ClearLabels()
        {
            this.FNameErrorLabel.Text = "";
            this.LNameErrorLabel.Text = "";
            this.PhoneErrorLabel.Text = "";
            this.DOBErrorLabel.Text = "";
            this.GenderErrorLabel.Text = "";
            this.AddressErrorLabel.Text = "";
            this.StateErrorLabel.Text = "";
            this.ZipErrorLabel.Text = "";
            this.MessageLabel.Text = "";
            this.MessageLabel.ForeColor = System.Drawing.Color.Black;
        }

        private void ClearInputs() 
        {
            this.FirstNameTextBox.Clear();
            this.LastNameTextBox.Clear();
            this.PhoneTextBox.Clear();
            this.DOBTextBox.Clear();
            this.AddressTextBox.Clear();
            this.ZipTextBox.Clear();
            this.GenderComboBox.SelectedIndex = -1;
            this.StateComboBox.SelectedIndex = -1;
        }
        #endregion

        private bool Validate()
        {
            bool isValid = true;
            this.ClearLabels();

            // First Name
            if (string.IsNullOrWhiteSpace(this.FirstNameTextBox.Text) || this.FirstNameTextBox.Text.Length < 2)
            {
                this.FNameErrorLabel.Text = "First name is required (min 2 chars)";
                isValid = false;
            }

            // Last Name
            if (string.IsNullOrWhiteSpace(this.LastNameTextBox.Text) || this.LastNameTextBox.Text.Length < 2)
            {
                this.LNameErrorLabel.Text = "Last name is required (min 2 chars)";
                isValid = false;
            }

            // Phone
            if (string.IsNullOrWhiteSpace(this.PhoneTextBox.Text) || this.PhoneTextBox.Text.Length < 10)
            {
                this.PhoneErrorLabel.Text = "Valid phone number required";
                isValid = false;
            }

            // DOB
            if (!DateTime.TryParse(this.DOBTextBox.Text, out DateTime dob))
            {
                this.DOBErrorLabel.Text = "Valid date of birth required";
                isValid = false;
            }

            // Gender
            if (this.GenderComboBox.SelectedIndex == -1)
            {
                this.GenderErrorLabel.Text = "Please select gender";
                isValid = false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(this.AddressTextBox.Text))
            {
                this.AddressErrorLabel.Text = "Address is required";
                isValid = false;
            }

            // State
            if (this.StateComboBox.SelectedIndex == -1)
            {
                this.StateErrorLabel.Text = "Please select a state";
                isValid = false;
            }

            // Zip Code (5 digits)
            if (string.IsNullOrWhiteSpace(this.ZipTextBox.Text) || this.ZipTextBox.Text.Length != 5 || !int.TryParse(this.ZipTextBox.Text, out _))
            {
                this.ZipErrorLabel.Text = "Valid 5-digit zip code required";
                isValid = false;
            }

            if (!isValid)
            {
                this.MessageLabel.Text = "Please fix the errors noted";
                this.MessageLabel.ForeColor = Color.Red;
            }
                
            return isValid;
        }

    }
}

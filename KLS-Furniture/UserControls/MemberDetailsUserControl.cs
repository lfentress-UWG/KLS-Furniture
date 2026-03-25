using KLS_Furniture.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KLS_Furniture.Model;


namespace KLS_Furniture.UserControls
{
    /// <summary>
    /// User control class that handles Member info add, edit, and display functionality
    /// </summary>
    public partial class MemberDetailsUserControl : UserControl
    {
        //Class variable that tracks edit vs new member function
        private bool _isEdit = false;
        //Class variable that track current member displayed
        private int _currentMemberID = -1;

        /// <summary>
        /// Contructor of MemberDetailsUserControl Class
        /// </summary>
        public MemberDetailsUserControl()
        {
            InitializeComponent();
            this.DisableAllFields();
            this.PopulateStateCombo();
            this.PopulateGenderCombo();
            this.EditMemberButton.Enabled = false;
            this.SaveMemberButton.Enabled = false;
            this.BindUpdateClears();

        }

        /// <summary>
        /// Loads member data but keeps everything disabled
        /// Edit requires selecting Edit button
        /// </summary>
        /// <param name="member"> Member object to be displayed/edited</param>
        public void DisplayMember(Member member)
        {
            this._isEdit = false;
            this._currentMemberID = member.MemberID;

            this.FirstNameTextBox.Text = member.FirstName;
            this.LastNameTextBox.Text = member.LastName;
            this.PhoneTextBox.Text = member.Phone;
            this.DOBTextBox.Text = member.DateOfBirth.ToShortDateString();
            this.GenderComboBox.SelectedValue = member.Sex;
            this.AddressTextBox.Text = member.Address;
            this.StateComboBox.SelectedValue = member.State;
            this.ZipTextBox.Text = member.ZipCode;

            this.DisableAllFields();
            this.AddMemberButton.Enabled = true;
            this.EditMemberButton.Enabled = true;
            this.SaveMemberButton.Enabled = false;
            this.MessageLabel.Text = "Member details loaded. Click Edit to update.";
        }

        #region
        //Button response functions
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            this.ClearLabels();
            this.ClearInputs();
            this.EnableAllFields();
            this.AddMemberButton.Enabled = false;
            this.EditMemberButton.Enabled = false;
            this.SaveMemberButton.Enabled = true;
            this.MessageLabel.Text = "Click Save to complete member add.";
        }

        private void EditMemberButton_Click(object sender, EventArgs e)
        {
            this._isEdit = true;
            this.EnableAllFields();
            this.AddMemberButton.Enabled = false;
            this.EditMemberButton.Enabled = false;
            this.SaveMemberButton.Enabled = true;
            this.MessageLabel.Text = "Editing member, click Save to update.";
        }

        private void SaveMemberButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;

            //ToDo: Send info to controller for processing

            this.ClearLabels();
            this.ClearInputs();
            this.MessageLabel.Text = _isEdit ? "Member updated successfully!" : "New member added successfully!";
            this.DisableAllFields();
            this.EditMemberButton.Enabled = true;
            this.SaveMemberButton.Enabled = false;
        }

        private void CancelMemberButton_Click(object sender, EventArgs e)
        {
            this.ClearLabels();
            this.ClearInputs();
            this.DisableAllFields();
            this.AddMemberButton.Enabled = true;
            this.SaveMemberButton.Enabled = false;
            if (this._currentMemberID != -1)
            {
                this.EditMemberButton.Enabled = true;
            } else
            {
                this.EditMemberButton.Enabled = false;
            }
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

        private void BindUpdateClears()
        {
            this.FirstNameTextBox.TextChanged += (s, e) => this.ClearLabels();
            this.LastNameTextBox.TextChanged += (s, e) => this.ClearLabels();
            this.PhoneTextBox.TextChanged += (s, e) => this.ClearLabels();
            this.DOBTextBox.TextChanged += (s, e) => this.ClearLabels();
            this.AddressTextBox.TextChanged += (s, e) => this.ClearLabels();
            this.ZipTextBox.TextChanged += (s, e) => this.ClearLabels();
            this.StateComboBox.SelectedValueChanged += (s, e) => this.ClearLabels();
            this.GenderComboBox.SelectedValueChanged += (s, e) => this.ClearLabels();
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
            if (!DateTime.TryParse(this.DOBTextBox.Text, out DateTime dob) || dob > DateTime.Today.AddYears(-18))
            {
                this.DOBErrorLabel.Text = "Valid date of birth required (Must be 18+)";
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

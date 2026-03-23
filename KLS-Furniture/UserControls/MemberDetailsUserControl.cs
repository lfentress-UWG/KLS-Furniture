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
            this.PopulateStateCombo();
            this.PopulateGenderCombo();
            
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {

        }

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
    }
}

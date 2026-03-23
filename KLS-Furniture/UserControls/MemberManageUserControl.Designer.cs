namespace KLS_Furniture.UserControls
{
    partial class MemberManageUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MemberMangeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MemberManageLabel = new System.Windows.Forms.Label();
            this.memberDetailsUserControl1 = new KLS_Furniture.UserControls.MemberDetailsUserControl();
            this.MemberMangeTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberMangeTableLayoutPanel
            // 
            this.MemberMangeTableLayoutPanel.ColumnCount = 1;
            this.MemberMangeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MemberMangeTableLayoutPanel.Controls.Add(this.MemberManageLabel, 0, 0);
            this.MemberMangeTableLayoutPanel.Controls.Add(this.memberDetailsUserControl1, 0, 3);
            this.MemberMangeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberMangeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MemberMangeTableLayoutPanel.Name = "MemberMangeTableLayoutPanel";
            this.MemberMangeTableLayoutPanel.RowCount = 4;
            this.MemberMangeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MemberMangeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.64146F));
            this.MemberMangeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.897F));
            this.MemberMangeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.33116F));
            this.MemberMangeTableLayoutPanel.Size = new System.Drawing.Size(790, 803);
            this.MemberMangeTableLayoutPanel.TabIndex = 0;
            // 
            // MemberManageLabel
            // 
            this.MemberManageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MemberManageLabel.AutoSize = true;
            this.MemberManageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberManageLabel.Location = new System.Drawing.Point(3, 5);
            this.MemberManageLabel.Name = "MemberManageLabel";
            this.MemberManageLabel.Size = new System.Drawing.Size(188, 20);
            this.MemberManageLabel.TabIndex = 0;
            this.MemberManageLabel.Text = "Member Management";
            this.MemberManageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memberDetailsUserControl1
            // 
            this.memberDetailsUserControl1.AutoSize = true;
            this.memberDetailsUserControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.memberDetailsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberDetailsUserControl1.Location = new System.Drawing.Point(3, 508);
            this.memberDetailsUserControl1.Name = "memberDetailsUserControl1";
            this.memberDetailsUserControl1.Size = new System.Drawing.Size(784, 292);
            this.memberDetailsUserControl1.TabIndex = 1;
            // 
            // MemberManageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberMangeTableLayoutPanel);
            this.Name = "MemberManageUserControl";
            this.Size = new System.Drawing.Size(790, 803);
            this.MemberMangeTableLayoutPanel.ResumeLayout(false);
            this.MemberMangeTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MemberMangeTableLayoutPanel;
        private System.Windows.Forms.Label MemberManageLabel;
        private MemberDetailsUserControl memberDetailsUserControl1;
    }
}

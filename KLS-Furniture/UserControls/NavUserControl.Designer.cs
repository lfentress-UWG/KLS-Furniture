namespace KLS_Furniture.UserControls
{
    partial class NavUserControl
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
            this.NavTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NavLabel = new System.Windows.Forms.Label();
            this.MemberManageNavButton = new System.Windows.Forms.Button();
            this.RentalNavButton = new System.Windows.Forms.Button();
            this.ReturnsNavButton = new System.Windows.Forms.Button();
            this.MemberHistNavButton = new System.Windows.Forms.Button();
            this.AdminReportNavButton = new System.Windows.Forms.Button();
            this.NavTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavTableLayoutPanel
            // 
            this.NavTableLayoutPanel.ColumnCount = 1;
            this.NavTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavTableLayoutPanel.Controls.Add(this.NavLabel, 0, 0);
            this.NavTableLayoutPanel.Controls.Add(this.MemberManageNavButton, 0, 1);
            this.NavTableLayoutPanel.Controls.Add(this.RentalNavButton, 0, 2);
            this.NavTableLayoutPanel.Controls.Add(this.ReturnsNavButton, 0, 3);
            this.NavTableLayoutPanel.Controls.Add(this.MemberHistNavButton, 0, 4);
            this.NavTableLayoutPanel.Controls.Add(this.AdminReportNavButton, 0, 5);
            this.NavTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.NavTableLayoutPanel.Name = "NavTableLayoutPanel";
            this.NavTableLayoutPanel.RowCount = 7;
            this.NavTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavTableLayoutPanel.Size = new System.Drawing.Size(161, 367);
            this.NavTableLayoutPanel.TabIndex = 0;
            // 
            // NavLabel
            // 
            this.NavLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NavLabel.AutoSize = true;
            this.NavLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavLabel.Location = new System.Drawing.Point(3, 17);
            this.NavLabel.Name = "NavLabel";
            this.NavLabel.Size = new System.Drawing.Size(155, 16);
            this.NavLabel.TabIndex = 0;
            this.NavLabel.Text = "Navigation";
            this.NavLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberManageNavButton
            // 
            this.MemberManageNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberManageNavButton.Location = new System.Drawing.Point(3, 53);
            this.MemberManageNavButton.Name = "MemberManageNavButton";
            this.MemberManageNavButton.Size = new System.Drawing.Size(155, 44);
            this.MemberManageNavButton.TabIndex = 1;
            this.MemberManageNavButton.Text = "Member Management";
            this.MemberManageNavButton.UseVisualStyleBackColor = true;
            this.MemberManageNavButton.Click += new System.EventHandler(this.MemberManageNavButton_Click);
            // 
            // RentalNavButton
            // 
            this.RentalNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentalNavButton.Location = new System.Drawing.Point(3, 103);
            this.RentalNavButton.Name = "RentalNavButton";
            this.RentalNavButton.Size = new System.Drawing.Size(155, 44);
            this.RentalNavButton.TabIndex = 2;
            this.RentalNavButton.Text = "Furniture Rental";
            this.RentalNavButton.UseVisualStyleBackColor = true;
            this.RentalNavButton.Click += new System.EventHandler(this.RentalNavButton_Click);
            // 
            // ReturnsNavButton
            // 
            this.ReturnsNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnsNavButton.Location = new System.Drawing.Point(3, 153);
            this.ReturnsNavButton.Name = "ReturnsNavButton";
            this.ReturnsNavButton.Size = new System.Drawing.Size(155, 44);
            this.ReturnsNavButton.TabIndex = 3;
            this.ReturnsNavButton.Text = "Returns";
            this.ReturnsNavButton.UseVisualStyleBackColor = true;
            this.ReturnsNavButton.Click += new System.EventHandler(this.ReturnsNavButton_Click);
            // 
            // MemberHistNavButton
            // 
            this.MemberHistNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberHistNavButton.Location = new System.Drawing.Point(3, 203);
            this.MemberHistNavButton.Name = "MemberHistNavButton";
            this.MemberHistNavButton.Size = new System.Drawing.Size(155, 44);
            this.MemberHistNavButton.TabIndex = 4;
            this.MemberHistNavButton.Text = "Member History";
            this.MemberHistNavButton.UseVisualStyleBackColor = true;
            this.MemberHistNavButton.Click += new System.EventHandler(this.MemberHistNavButton_Click);
            // 
            // AdminReportNavButton
            // 
            this.AdminReportNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminReportNavButton.Location = new System.Drawing.Point(3, 253);
            this.AdminReportNavButton.Name = "AdminReportNavButton";
            this.AdminReportNavButton.Size = new System.Drawing.Size(155, 44);
            this.AdminReportNavButton.TabIndex = 5;
            this.AdminReportNavButton.Text = "Admin Reports";
            this.AdminReportNavButton.UseVisualStyleBackColor = true;
            this.AdminReportNavButton.Click += new System.EventHandler(this.AdminReportNavButton_Click);
            // 
            // NavUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavTableLayoutPanel);
            this.Name = "NavUserControl";
            this.Size = new System.Drawing.Size(161, 367);
            this.NavTableLayoutPanel.ResumeLayout(false);
            this.NavTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NavTableLayoutPanel;
        private System.Windows.Forms.Label NavLabel;
        private System.Windows.Forms.Button MemberManageNavButton;
        private System.Windows.Forms.Button RentalNavButton;
        private System.Windows.Forms.Button ReturnsNavButton;
        private System.Windows.Forms.Button MemberHistNavButton;
        private System.Windows.Forms.Button AdminReportNavButton;
    }
}

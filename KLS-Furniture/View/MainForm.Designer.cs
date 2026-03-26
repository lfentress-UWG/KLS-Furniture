namespace KLS_Furniture
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.navUserControl1 = new KLS_Furniture.UserControls.NavUserControl();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainTableLayoutPanel.SetColumnSpan(this.HeaderPanel, 2);
            this.HeaderPanel.Controls.Add(this.LogoutButton);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(972, 53);
            this.HeaderPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RentMe Furniture Rental System";
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(151, 62);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(824, 816);
            this.ContentPanel.TabIndex = 2;
            // 
            // navUserControl1
            // 
            this.navUserControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.navUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navUserControl1.Location = new System.Drawing.Point(3, 62);
            this.navUserControl1.Name = "navUserControl1";
            this.navUserControl1.Size = new System.Drawing.Size(142, 816);
            this.navUserControl1.TabIndex = 0;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.19824F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.80177F));
            this.MainTableLayoutPanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ContentPanel, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.navUserControl1, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.696935F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.30306F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(978, 881);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightCoral;
            this.LogoutButton.Location = new System.Drawing.Point(888, 9);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 33);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(978, 881);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NavUserControl navUserControl1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Button LogoutButton;
    }
}


namespace OverRandomUI
{
	partial class AboutWindow
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
			this.topBorderPanel = new System.Windows.Forms.Panel();
			this.bottomBorderPanel = new System.Windows.Forms.Panel();
			this.rightBorderPanel = new System.Windows.Forms.Panel();
			this.leftBorderPanel = new System.Windows.Forms.Panel();
			this.aboutHeaderLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// topBorderPanel
			// 
			this.topBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
			this.topBorderPanel.Name = "topBorderPanel";
			this.topBorderPanel.Size = new System.Drawing.Size(500, 2);
			this.topBorderPanel.TabIndex = 14;
			// 
			// bottomBorderPanel
			// 
			this.bottomBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.bottomBorderPanel.Location = new System.Drawing.Point(0, 198);
			this.bottomBorderPanel.Name = "bottomBorderPanel";
			this.bottomBorderPanel.Size = new System.Drawing.Size(500, 2);
			this.bottomBorderPanel.TabIndex = 14;
			// 
			// rightBorderPanel
			// 
			this.rightBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.rightBorderPanel.Location = new System.Drawing.Point(498, 0);
			this.rightBorderPanel.Name = "rightBorderPanel";
			this.rightBorderPanel.Size = new System.Drawing.Size(2, 200);
			this.rightBorderPanel.TabIndex = 14;
			// 
			// leftBorderPanel
			// 
			this.leftBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
			this.leftBorderPanel.Name = "leftBorderPanel";
			this.leftBorderPanel.Size = new System.Drawing.Size(2, 200);
			this.leftBorderPanel.TabIndex = 14;
			// 
			// aboutHeaderLabel
			// 
			this.aboutHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.aboutHeaderLabel.Location = new System.Drawing.Point(2, 4);
			this.aboutHeaderLabel.Name = "aboutHeaderLabel";
			this.aboutHeaderLabel.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.aboutHeaderLabel.Size = new System.Drawing.Size(496, 28);
			this.aboutHeaderLabel.TabIndex = 15;
			this.aboutHeaderLabel.Text = "About";
			this.aboutHeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movementPanel_MouseDown);
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = global::OverRandomUI.Properties.Resources.closebutton;
			this.closeButton.Location = new System.Drawing.Point(472, 12);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(16, 16);
			this.closeButton.TabIndex = 13;
			this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseClick);
			this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
			this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
			// 
			// AboutWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(500, 200);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.aboutHeaderLabel);
			this.Controls.Add(this.leftBorderPanel);
			this.Controls.Add(this.rightBorderPanel);
			this.Controls.Add(this.bottomBorderPanel);
			this.Controls.Add(this.topBorderPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AboutWindow";
			this.Text = "AboutWindow";
			this.Load += new System.EventHandler(this.AboutWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel closeButton;
		private System.Windows.Forms.Panel topBorderPanel;
		private System.Windows.Forms.Panel bottomBorderPanel;
		private System.Windows.Forms.Panel rightBorderPanel;
		private System.Windows.Forms.Panel leftBorderPanel;
		private System.Windows.Forms.Label aboutHeaderLabel;
	}
}
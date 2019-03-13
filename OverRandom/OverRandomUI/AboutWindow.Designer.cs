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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
			this.topBorderPanel = new System.Windows.Forms.Panel();
			this.bottomBorderPanel = new System.Windows.Forms.Panel();
			this.rightBorderPanel = new System.Windows.Forms.Panel();
			this.leftBorderPanel = new System.Windows.Forms.Panel();
			this.aboutHeaderLabel = new System.Windows.Forms.Label();
			this.dividerPanel = new System.Windows.Forms.Panel();
			this.contentLabel = new System.Windows.Forms.Label();
			this.twitterLabel = new System.Windows.Forms.LinkLabel();
			this.twitchLabel = new System.Windows.Forms.LinkLabel();
			this.githubLabel = new System.Windows.Forms.LinkLabel();
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
			this.aboutHeaderLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.aboutHeaderLabel.Size = new System.Drawing.Size(496, 28);
			this.aboutHeaderLabel.TabIndex = 15;
			this.aboutHeaderLabel.Text = "About";
			this.aboutHeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movementPanel_MouseDown);
			// 
			// dividerPanel
			// 
			this.dividerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.dividerPanel.Location = new System.Drawing.Point(0, 34);
			this.dividerPanel.Name = "dividerPanel";
			this.dividerPanel.Size = new System.Drawing.Size(500, 2);
			this.dividerPanel.TabIndex = 16;
			// 
			// contentLabel
			// 
			this.contentLabel.BackColor = System.Drawing.Color.Transparent;
			this.contentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.contentLabel.Location = new System.Drawing.Point(3, 39);
			this.contentLabel.Name = "contentLabel";
			this.contentLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.contentLabel.Size = new System.Drawing.Size(496, 104);
			this.contentLabel.TabIndex = 17;
			this.contentLabel.Text = "Version 0.1\r\nCreated by Verathis";
			// 
			// twitterLabel
			// 
			this.twitterLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.twitterLabel.AutoSize = true;
			this.twitterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.twitterLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.twitterLabel.Location = new System.Drawing.Point(13, 139);
			this.twitterLabel.Name = "twitterLabel";
			this.twitterLabel.Size = new System.Drawing.Size(39, 13);
			this.twitterLabel.TabIndex = 18;
			this.twitterLabel.TabStop = true;
			this.twitterLabel.Text = "Twitter";
			this.twitterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitterLabel_LinkClicked);
			// 
			// twitchLabel
			// 
			this.twitchLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.twitchLabel.AutoSize = true;
			this.twitchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.twitchLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.twitchLabel.Location = new System.Drawing.Point(13, 163);
			this.twitchLabel.Name = "twitchLabel";
			this.twitchLabel.Size = new System.Drawing.Size(81, 13);
			this.twitchLabel.TabIndex = 19;
			this.twitchLabel.TabStop = true;
			this.twitchLabel.Text = "Twitch Channel";
			this.twitchLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitchLabel_LinkClicked);
			// 
			// githubLabel
			// 
			this.githubLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.githubLabel.AutoSize = true;
			this.githubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.githubLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.githubLabel.Location = new System.Drawing.Point(13, 115);
			this.githubLabel.Name = "githubLabel";
			this.githubLabel.Size = new System.Drawing.Size(38, 13);
			this.githubLabel.TabIndex = 18;
			this.githubLabel.TabStop = true;
			this.githubLabel.Text = "Github";
			this.githubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLabel_LinkClicked);
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = global::OverRandomUI.Properties.Resources.closebutton;
			this.closeButton.Location = new System.Drawing.Point(475, 6);
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
			this.Controls.Add(this.twitchLabel);
			this.Controls.Add(this.githubLabel);
			this.Controls.Add(this.twitterLabel);
			this.Controls.Add(this.contentLabel);
			this.Controls.Add(this.dividerPanel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.aboutHeaderLabel);
			this.Controls.Add(this.leftBorderPanel);
			this.Controls.Add(this.rightBorderPanel);
			this.Controls.Add(this.bottomBorderPanel);
			this.Controls.Add(this.topBorderPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AboutWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.Load += new System.EventHandler(this.AboutWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel closeButton;
		private System.Windows.Forms.Panel topBorderPanel;
		private System.Windows.Forms.Panel bottomBorderPanel;
		private System.Windows.Forms.Panel rightBorderPanel;
		private System.Windows.Forms.Panel leftBorderPanel;
		private System.Windows.Forms.Label aboutHeaderLabel;
		private System.Windows.Forms.Panel dividerPanel;
		private System.Windows.Forms.Label contentLabel;
		private System.Windows.Forms.LinkLabel twitterLabel;
		private System.Windows.Forms.LinkLabel twitchLabel;
		private System.Windows.Forms.LinkLabel githubLabel;
	}
}
namespace OverRandomUI
{
	partial class MainWindow
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
			this.randomTankOneLabel = new System.Windows.Forms.Label();
			this.randomSupportOneLabel = new System.Windows.Forms.Label();
			this.randomTankButton = new System.Windows.Forms.Button();
			this.randomSupportButton = new System.Windows.Forms.Button();
			this.randomDamageButton = new System.Windows.Forms.Button();
			this.randomDamageOneLabel = new System.Windows.Forms.Label();
			this.overRandomLabel = new System.Windows.Forms.Label();
			this.movementPanel = new System.Windows.Forms.Panel();
			this.singleHeroLabel = new System.Windows.Forms.Label();
			this.leftBorderPanel = new System.Windows.Forms.Panel();
			this.rightBorderPanel = new System.Windows.Forms.Panel();
			this.topBorderPanel = new System.Windows.Forms.Panel();
			this.bottomBorderPanel = new System.Windows.Forms.Panel();
			this.randomAnyButton = new System.Windows.Forms.Button();
			this.dividerPanel = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Panel();
			this.minimizeButton = new System.Windows.Forms.Panel();
			this.randomTankTwoLabel = new System.Windows.Forms.Label();
			this.randomSupportTwoLabel = new System.Windows.Forms.Label();
			this.randomDamageTwoLabel = new System.Windows.Forms.Label();
			this.twoOfEachButton = new System.Windows.Forms.Button();
			this.aboutButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// randomTankOneLabel
			// 
			this.randomTankOneLabel.AutoSize = true;
			this.randomTankOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomTankOneLabel.Location = new System.Drawing.Point(199, 104);
			this.randomTankOneLabel.Name = "randomTankOneLabel";
			this.randomTankOneLabel.Size = new System.Drawing.Size(0, 13);
			this.randomTankOneLabel.TabIndex = 0;
			// 
			// randomSupportOneLabel
			// 
			this.randomSupportOneLabel.AutoSize = true;
			this.randomSupportOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomSupportOneLabel.Location = new System.Drawing.Point(199, 154);
			this.randomSupportOneLabel.Name = "randomSupportOneLabel";
			this.randomSupportOneLabel.Size = new System.Drawing.Size(0, 13);
			this.randomSupportOneLabel.TabIndex = 1;
			// 
			// randomTankButton
			// 
			this.randomTankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.randomTankButton.FlatAppearance.BorderSize = 0;
			this.randomTankButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.randomTankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randomTankButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomTankButton.Location = new System.Drawing.Point(12, 148);
			this.randomTankButton.Name = "randomTankButton";
			this.randomTankButton.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.randomTankButton.Size = new System.Drawing.Size(120, 30);
			this.randomTankButton.TabIndex = 2;
			this.randomTankButton.Text = "Random Tank";
			this.randomTankButton.UseVisualStyleBackColor = false;
			this.randomTankButton.Click += new System.EventHandler(this.randomTankButton_Click);
			// 
			// randomSupportButton
			// 
			this.randomSupportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.randomSupportButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.randomSupportButton.FlatAppearance.BorderSize = 0;
			this.randomSupportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.randomSupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randomSupportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomSupportButton.Location = new System.Drawing.Point(12, 183);
			this.randomSupportButton.Name = "randomSupportButton";
			this.randomSupportButton.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.randomSupportButton.Size = new System.Drawing.Size(120, 30);
			this.randomSupportButton.TabIndex = 3;
			this.randomSupportButton.Text = "Random Support";
			this.randomSupportButton.UseVisualStyleBackColor = false;
			this.randomSupportButton.Click += new System.EventHandler(this.randomHealerButton_Click);
			// 
			// randomDamageButton
			// 
			this.randomDamageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.randomDamageButton.FlatAppearance.BorderSize = 0;
			this.randomDamageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.randomDamageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randomDamageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomDamageButton.Location = new System.Drawing.Point(12, 218);
			this.randomDamageButton.Name = "randomDamageButton";
			this.randomDamageButton.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.randomDamageButton.Size = new System.Drawing.Size(120, 30);
			this.randomDamageButton.TabIndex = 4;
			this.randomDamageButton.Text = "Random Damage";
			this.randomDamageButton.UseVisualStyleBackColor = false;
			this.randomDamageButton.Click += new System.EventHandler(this.randomDamageButton_Click);
			// 
			// randomDamageOneLabel
			// 
			this.randomDamageOneLabel.AutoSize = true;
			this.randomDamageOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomDamageOneLabel.Location = new System.Drawing.Point(199, 204);
			this.randomDamageOneLabel.Name = "randomDamageOneLabel";
			this.randomDamageOneLabel.Size = new System.Drawing.Size(0, 13);
			this.randomDamageOneLabel.TabIndex = 5;
			// 
			// overRandomLabel
			// 
			this.overRandomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.overRandomLabel.Location = new System.Drawing.Point(0, 2);
			this.overRandomLabel.Name = "overRandomLabel";
			this.overRandomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
			this.overRandomLabel.Size = new System.Drawing.Size(700, 96);
			this.overRandomLabel.TabIndex = 6;
			this.overRandomLabel.Text = "Overwatch Randomizer";
			this.overRandomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.overRandomLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movementPanel_MouseDown);
			// 
			// movementPanel
			// 
			this.movementPanel.Location = new System.Drawing.Point(0, -17);
			this.movementPanel.Name = "movementPanel";
			this.movementPanel.Size = new System.Drawing.Size(696, 118);
			this.movementPanel.TabIndex = 7;
			this.movementPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movementPanel_MouseDown);
			// 
			// singleHeroLabel
			// 
			this.singleHeroLabel.AutoSize = true;
			this.singleHeroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.singleHeroLabel.Location = new System.Drawing.Point(199, 104);
			this.singleHeroLabel.Name = "singleHeroLabel";
			this.singleHeroLabel.Size = new System.Drawing.Size(0, 13);
			this.singleHeroLabel.TabIndex = 8;
			// 
			// leftBorderPanel
			// 
			this.leftBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.leftBorderPanel.ForeColor = System.Drawing.Color.Lime;
			this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
			this.leftBorderPanel.Name = "leftBorderPanel";
			this.leftBorderPanel.Size = new System.Drawing.Size(2, 350);
			this.leftBorderPanel.TabIndex = 9;
			// 
			// rightBorderPanel
			// 
			this.rightBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.rightBorderPanel.ForeColor = System.Drawing.Color.Lime;
			this.rightBorderPanel.Location = new System.Drawing.Point(698, 0);
			this.rightBorderPanel.Name = "rightBorderPanel";
			this.rightBorderPanel.Size = new System.Drawing.Size(2, 350);
			this.rightBorderPanel.TabIndex = 9;
			// 
			// topBorderPanel
			// 
			this.topBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
			this.topBorderPanel.Name = "topBorderPanel";
			this.topBorderPanel.Size = new System.Drawing.Size(700, 2);
			this.topBorderPanel.TabIndex = 10;
			// 
			// bottomBorderPanel
			// 
			this.bottomBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.bottomBorderPanel.Location = new System.Drawing.Point(0, 348);
			this.bottomBorderPanel.Name = "bottomBorderPanel";
			this.bottomBorderPanel.Size = new System.Drawing.Size(700, 2);
			this.bottomBorderPanel.TabIndex = 10;
			// 
			// randomAnyButton
			// 
			this.randomAnyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.randomAnyButton.FlatAppearance.BorderSize = 0;
			this.randomAnyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.randomAnyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randomAnyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomAnyButton.Location = new System.Drawing.Point(12, 113);
			this.randomAnyButton.Name = "randomAnyButton";
			this.randomAnyButton.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.randomAnyButton.Size = new System.Drawing.Size(120, 30);
			this.randomAnyButton.TabIndex = 2;
			this.randomAnyButton.Text = "Random Any";
			this.randomAnyButton.UseVisualStyleBackColor = false;
			this.randomAnyButton.Click += new System.EventHandler(this.randomAnyButton_Click);
			// 
			// dividerPanel
			// 
			this.dividerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.dividerPanel.Location = new System.Drawing.Point(0, 100);
			this.dividerPanel.Name = "dividerPanel";
			this.dividerPanel.Size = new System.Drawing.Size(700, 2);
			this.dividerPanel.TabIndex = 10;
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = global::OverRandomUI.Properties.Resources.closebutton;
			this.closeButton.Location = new System.Drawing.Point(675, 6);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(16, 16);
			this.closeButton.TabIndex = 11;
			this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseClick);
			this.closeButton.MouseEnter += new System.EventHandler(this.PanelHoverColor);
			this.closeButton.MouseLeave += new System.EventHandler(this.PanelDefaultColor);
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = global::OverRandomUI.Properties.Resources.minimizebutton;
			this.minimizeButton.Location = new System.Drawing.Point(655, 6);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(16, 16);
			this.minimizeButton.TabIndex = 11;
			this.minimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseClick);
			this.minimizeButton.MouseEnter += new System.EventHandler(this.PanelHoverColor);
			this.minimizeButton.MouseLeave += new System.EventHandler(this.PanelDefaultColor);
			// 
			// randomTankTwoLabel
			// 
			this.randomTankTwoLabel.AutoSize = true;
			this.randomTankTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomTankTwoLabel.Location = new System.Drawing.Point(457, 104);
			this.randomTankTwoLabel.Name = "randomTankTwoLabel";
			this.randomTankTwoLabel.Size = new System.Drawing.Size(0, 13);
			this.randomTankTwoLabel.TabIndex = 0;
			// 
			// randomSupportTwoLabel
			// 
			this.randomSupportTwoLabel.AutoSize = true;
			this.randomSupportTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomSupportTwoLabel.Location = new System.Drawing.Point(457, 154);
			this.randomSupportTwoLabel.Name = "randomSupportTwoLabel";
			this.randomSupportTwoLabel.Size = new System.Drawing.Size(0, 13);
			this.randomSupportTwoLabel.TabIndex = 1;
			// 
			// randomDamageTwoLabel
			// 
			this.randomDamageTwoLabel.AutoSize = true;
			this.randomDamageTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomDamageTwoLabel.Location = new System.Drawing.Point(457, 204);
			this.randomDamageTwoLabel.Name = "randomDamageTwoLabel";
			this.randomDamageTwoLabel.Size = new System.Drawing.Size(0, 13);
			this.randomDamageTwoLabel.TabIndex = 5;
			// 
			// twoOfEachButton
			// 
			this.twoOfEachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.twoOfEachButton.FlatAppearance.BorderSize = 0;
			this.twoOfEachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.twoOfEachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.twoOfEachButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.twoOfEachButton.Location = new System.Drawing.Point(12, 253);
			this.twoOfEachButton.Name = "twoOfEachButton";
			this.twoOfEachButton.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.twoOfEachButton.Size = new System.Drawing.Size(120, 30);
			this.twoOfEachButton.TabIndex = 4;
			this.twoOfEachButton.Text = "2 / 2 / 2";
			this.twoOfEachButton.UseVisualStyleBackColor = false;
			this.twoOfEachButton.Click += new System.EventHandler(this.twoOfEachButton_Click);
			// 
			// aboutButton
			// 
			this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.aboutButton.FlatAppearance.BorderSize = 0;
			this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.aboutButton.Location = new System.Drawing.Point(12, 308);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.aboutButton.Size = new System.Drawing.Size(120, 30);
			this.aboutButton.TabIndex = 4;
			this.aboutButton.Text = "About";
			this.aboutButton.UseVisualStyleBackColor = false;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(700, 350);
			this.Controls.Add(this.minimizeButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.dividerPanel);
			this.Controls.Add(this.bottomBorderPanel);
			this.Controls.Add(this.topBorderPanel);
			this.Controls.Add(this.rightBorderPanel);
			this.Controls.Add(this.leftBorderPanel);
			this.Controls.Add(this.overRandomLabel);
			this.Controls.Add(this.singleHeroLabel);
			this.Controls.Add(this.movementPanel);
			this.Controls.Add(this.randomDamageTwoLabel);
			this.Controls.Add(this.randomDamageOneLabel);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.twoOfEachButton);
			this.Controls.Add(this.randomDamageButton);
			this.Controls.Add(this.randomSupportButton);
			this.Controls.Add(this.randomAnyButton);
			this.Controls.Add(this.randomSupportTwoLabel);
			this.Controls.Add(this.randomTankButton);
			this.Controls.Add(this.randomTankTwoLabel);
			this.Controls.Add(this.randomSupportOneLabel);
			this.Controls.Add(this.randomTankOneLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainWindow";
			this.Text = "Overwatch Randomizer";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label randomTankOneLabel;
		private System.Windows.Forms.Label randomSupportOneLabel;
		private System.Windows.Forms.Button randomTankButton;
		private System.Windows.Forms.Button randomSupportButton;
		private System.Windows.Forms.Button randomDamageButton;
		private System.Windows.Forms.Label randomDamageOneLabel;
		private System.Windows.Forms.Label overRandomLabel;
		private System.Windows.Forms.Panel movementPanel;
		private System.Windows.Forms.Label singleHeroLabel;
		private System.Windows.Forms.Panel leftBorderPanel;
		private System.Windows.Forms.Panel rightBorderPanel;
		private System.Windows.Forms.Panel topBorderPanel;
		private System.Windows.Forms.Panel bottomBorderPanel;
		private System.Windows.Forms.Button randomAnyButton;
		private System.Windows.Forms.Panel dividerPanel;
		private System.Windows.Forms.Panel closeButton;
		private System.Windows.Forms.Panel minimizeButton;
		private System.Windows.Forms.Label randomTankTwoLabel;
		private System.Windows.Forms.Label randomSupportTwoLabel;
		private System.Windows.Forms.Label randomDamageTwoLabel;
		private System.Windows.Forms.Button twoOfEachButton;
		private System.Windows.Forms.Button aboutButton;
	}
}


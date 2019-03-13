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
			this.randomTankLabel = new System.Windows.Forms.Label();
			this.randomHealerLabel = new System.Windows.Forms.Label();
			this.randomTankButton = new System.Windows.Forms.Button();
			this.randomHealerButton = new System.Windows.Forms.Button();
			this.randomDamageButton = new System.Windows.Forms.Button();
			this.randomDamageLabel = new System.Windows.Forms.Label();
			this.overRandomLabel = new System.Windows.Forms.Label();
			this.movementPanel = new System.Windows.Forms.Panel();
			this.movementPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// randomTankLabel
			// 
			this.randomTankLabel.AutoSize = true;
			this.randomTankLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomTankLabel.Location = new System.Drawing.Point(118, 136);
			this.randomTankLabel.Name = "randomTankLabel";
			this.randomTankLabel.Size = new System.Drawing.Size(0, 13);
			this.randomTankLabel.TabIndex = 0;
			// 
			// randomHealerLabel
			// 
			this.randomHealerLabel.AutoSize = true;
			this.randomHealerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomHealerLabel.Location = new System.Drawing.Point(118, 216);
			this.randomHealerLabel.Name = "randomHealerLabel";
			this.randomHealerLabel.Size = new System.Drawing.Size(0, 13);
			this.randomHealerLabel.TabIndex = 1;
			// 
			// randomTankButton
			// 
			this.randomTankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.randomTankButton.FlatAppearance.BorderSize = 0;
			this.randomTankButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.randomTankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randomTankButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomTankButton.Location = new System.Drawing.Point(12, 134);
			this.randomTankButton.Name = "randomTankButton";
			this.randomTankButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.randomTankButton.Size = new System.Drawing.Size(100, 40);
			this.randomTankButton.TabIndex = 2;
			this.randomTankButton.Text = "Random Tank";
			this.randomTankButton.UseVisualStyleBackColor = false;
			this.randomTankButton.Click += new System.EventHandler(this.randomTankButton_Click);
			// 
			// randomHealerButton
			// 
			this.randomHealerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.randomHealerButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.randomHealerButton.FlatAppearance.BorderSize = 0;
			this.randomHealerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.randomHealerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randomHealerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomHealerButton.Location = new System.Drawing.Point(12, 214);
			this.randomHealerButton.Name = "randomHealerButton";
			this.randomHealerButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.randomHealerButton.Size = new System.Drawing.Size(100, 40);
			this.randomHealerButton.TabIndex = 3;
			this.randomHealerButton.Text = "Random Healer";
			this.randomHealerButton.UseVisualStyleBackColor = false;
			this.randomHealerButton.Click += new System.EventHandler(this.randomHealerButton_Click);
			// 
			// randomDamageButton
			// 
			this.randomDamageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
			this.randomDamageButton.FlatAppearance.BorderSize = 0;
			this.randomDamageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(51)))));
			this.randomDamageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randomDamageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomDamageButton.Location = new System.Drawing.Point(12, 294);
			this.randomDamageButton.Name = "randomDamageButton";
			this.randomDamageButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.randomDamageButton.Size = new System.Drawing.Size(100, 40);
			this.randomDamageButton.TabIndex = 4;
			this.randomDamageButton.Text = "Random Damage";
			this.randomDamageButton.UseVisualStyleBackColor = false;
			this.randomDamageButton.Click += new System.EventHandler(this.randomDamageButton_Click);
			// 
			// randomDamageLabel
			// 
			this.randomDamageLabel.AutoSize = true;
			this.randomDamageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.randomDamageLabel.Location = new System.Drawing.Point(118, 296);
			this.randomDamageLabel.Name = "randomDamageLabel";
			this.randomDamageLabel.Size = new System.Drawing.Size(0, 13);
			this.randomDamageLabel.TabIndex = 5;
			// 
			// overRandomLabel
			// 
			this.overRandomLabel.AutoSize = true;
			this.overRandomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.overRandomLabel.Location = new System.Drawing.Point(31, 13);
			this.overRandomLabel.Name = "overRandomLabel";
			this.overRandomLabel.Size = new System.Drawing.Size(118, 13);
			this.overRandomLabel.TabIndex = 6;
			this.overRandomLabel.Text = "Overwatch Randomizer";
			// 
			// movementPanel
			// 
			this.movementPanel.Controls.Add(this.overRandomLabel);
			this.movementPanel.Location = new System.Drawing.Point(0, 0);
			this.movementPanel.Name = "movementPanel";
			this.movementPanel.Size = new System.Drawing.Size(696, 118);
			this.movementPanel.TabIndex = 7;
			this.movementPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movementPanel_MouseDown);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(694, 355);
			this.Controls.Add(this.movementPanel);
			this.Controls.Add(this.randomDamageLabel);
			this.Controls.Add(this.randomDamageButton);
			this.Controls.Add(this.randomHealerButton);
			this.Controls.Add(this.randomTankButton);
			this.Controls.Add(this.randomHealerLabel);
			this.Controls.Add(this.randomTankLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainWindow";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.movementPanel.ResumeLayout(false);
			this.movementPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label randomTankLabel;
		private System.Windows.Forms.Label randomHealerLabel;
		private System.Windows.Forms.Button randomTankButton;
		private System.Windows.Forms.Button randomHealerButton;
		private System.Windows.Forms.Button randomDamageButton;
		private System.Windows.Forms.Label randomDamageLabel;
		private System.Windows.Forms.Label overRandomLabel;
		private System.Windows.Forms.Panel movementPanel;
	}
}


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
			this.SuspendLayout();
			// 
			// randomTankLabel
			// 
			this.randomTankLabel.AutoSize = true;
			this.randomTankLabel.Location = new System.Drawing.Point(138, 134);
			this.randomTankLabel.Name = "randomTankLabel";
			this.randomTankLabel.Size = new System.Drawing.Size(78, 13);
			this.randomTankLabel.TabIndex = 0;
			this.randomTankLabel.Text = "Random Tank!";
			// 
			// randomHealerLabel
			// 
			this.randomHealerLabel.AutoSize = true;
			this.randomHealerLabel.Location = new System.Drawing.Point(138, 214);
			this.randomHealerLabel.Name = "randomHealerLabel";
			this.randomHealerLabel.Size = new System.Drawing.Size(84, 13);
			this.randomHealerLabel.TabIndex = 1;
			this.randomHealerLabel.Text = "Random Healer!";
			// 
			// randomTankButton
			// 
			this.randomTankButton.Location = new System.Drawing.Point(12, 134);
			this.randomTankButton.Name = "randomTankButton";
			this.randomTankButton.Size = new System.Drawing.Size(100, 40);
			this.randomTankButton.TabIndex = 2;
			this.randomTankButton.Text = "Random Tank";
			this.randomTankButton.UseVisualStyleBackColor = true;
			this.randomTankButton.Click += new System.EventHandler(this.randomTankButton_Click);
			// 
			// randomHealerButton
			// 
			this.randomHealerButton.Location = new System.Drawing.Point(12, 214);
			this.randomHealerButton.Name = "randomHealerButton";
			this.randomHealerButton.Size = new System.Drawing.Size(100, 40);
			this.randomHealerButton.TabIndex = 3;
			this.randomHealerButton.Text = "Random Healer";
			this.randomHealerButton.UseVisualStyleBackColor = true;
			this.randomHealerButton.Click += new System.EventHandler(this.randomHealerButton_Click);
			// 
			// randomDamageButton
			// 
			this.randomDamageButton.Location = new System.Drawing.Point(12, 294);
			this.randomDamageButton.Name = "randomDamageButton";
			this.randomDamageButton.Size = new System.Drawing.Size(100, 40);
			this.randomDamageButton.TabIndex = 4;
			this.randomDamageButton.Text = "Random Damage";
			this.randomDamageButton.UseVisualStyleBackColor = true;
			this.randomDamageButton.Click += new System.EventHandler(this.randomDamageButton_Click);
			// 
			// randomDamageLabel
			// 
			this.randomDamageLabel.AutoSize = true;
			this.randomDamageLabel.Location = new System.Drawing.Point(138, 294);
			this.randomDamageLabel.Name = "randomDamageLabel";
			this.randomDamageLabel.Size = new System.Drawing.Size(93, 13);
			this.randomDamageLabel.TabIndex = 5;
			this.randomDamageLabel.Text = "Random Damage!";
			// 
			// overRandomLabel
			// 
			this.overRandomLabel.AutoSize = true;
			this.overRandomLabel.Location = new System.Drawing.Point(31, 13);
			this.overRandomLabel.Name = "overRandomLabel";
			this.overRandomLabel.Size = new System.Drawing.Size(118, 13);
			this.overRandomLabel.TabIndex = 6;
			this.overRandomLabel.Text = "Overwatch Randomizer";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 355);
			this.Controls.Add(this.overRandomLabel);
			this.Controls.Add(this.randomDamageLabel);
			this.Controls.Add(this.randomDamageButton);
			this.Controls.Add(this.randomHealerButton);
			this.Controls.Add(this.randomTankButton);
			this.Controls.Add(this.randomHealerLabel);
			this.Controls.Add(this.randomTankLabel);
			this.Name = "MainWindow";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainWindow_Load);
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
	}
}


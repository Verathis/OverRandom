﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using RandomizerLib;
using System.Runtime.InteropServices;

namespace OverRandomUI
{
	public partial class MainWindow : Form
	{
		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
			IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

		private PrivateFontCollection fonts = new PrivateFontCollection();

		Font headerFont;
		Font labelFont;
		Font buttonFont;

		RandomSelector randomSelection = new RandomSelector();

		public MainWindow()
		{
			InitializeComponent();

			byte[] fontData = Properties.Resources.OverwatchFont;
			IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
			System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			uint dummy = 0;
			fonts.AddMemoryFont(fontPtr, Properties.Resources.OverwatchFont.Length);
			AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.OverwatchFont.Length, IntPtr.Zero, ref dummy);
			System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

			headerFont = new Font(fonts.Families[0], 60.0F);
			labelFont = new Font(fonts.Families[0], 24.0F);
			buttonFont = new Font(fonts.Families[0], 16.0F);
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			randomTankLabel.Font = labelFont;
			randomHealerLabel.Font = labelFont;
			randomDamageLabel.Font = labelFont;
			overRandomLabel.Font = headerFont;
			randomDamageButton.Font = buttonFont;
			randomHealerButton.Font = buttonFont;
			randomTankButton.Font = buttonFont;
		}

		private void randomTankButton_Click(object sender, EventArgs e)
		{
			randomTankLabel.Text = randomSelection.RandomTank().HeroName;
			
		}

		private void randomHealerButton_Click(object sender, EventArgs e)
		{
			randomHealerLabel.Text = randomSelection.RandomSupport().HeroName;
		}

		private void randomDamageButton_Click(object sender, EventArgs e)
		{
			randomDamageLabel.Text = randomSelection.RandomDamage().HeroName;
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void movementPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		}
	}
}

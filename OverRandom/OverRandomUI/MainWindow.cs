using System;
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

		const string tankClass = "Tank";

		HeroModel dva = new HeroModel("D.Va", tankClass);
		HeroModel orisa = new HeroModel("Orisa", tankClass);
		HeroModel reinhardt = new HeroModel("Reinhardt", tankClass);
		HeroModel roadhog = new HeroModel("Roadhog", tankClass);
		HeroModel winston = new HeroModel("Winston", tankClass);
		HeroModel wreckingBall = new HeroModel("Wrecking Ball", tankClass);
		HeroModel zarya = new HeroModel("Zarya", tankClass);

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

			headerFont = new Font(fonts.Families[0], 72.0F);
			labelFont = new Font(fonts.Families[0], 24.0F);			
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			label1.Font = headerFont;
			label2.Font = labelFont;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//label1.Text = dva.TestMethod();
			//label2.Text = roadhog.TestMethod();
		}
	}
}

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
		Font singleLabelFont;

		Color hoverColor = ColorTranslator.FromHtml("#FF8900");
		Color backColor = ColorTranslator.FromHtml("#333333");
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
			singleLabelFont = new Font(fonts.Families[0], 36.0F);
			labelFont = new Font(fonts.Families[0], 36.0F);
			buttonFont = new Font(fonts.Families[0], 14.0F);
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			randomTankOneLabel.Font = labelFont;
			randomTankTwoLabel.Font = labelFont;
			randomSupportOneLabel.Font = labelFont;
			randomSupportTwoLabel.Font = labelFont;
			randomDamageOneLabel.Font = labelFont;
			randomDamageTwoLabel.Font = labelFont;
			overRandomLabel.Font = headerFont;
			randomAnyButton.Font = buttonFont;
			randomDamageButton.Font = buttonFont;
			randomSupportButton.Font = buttonFont;
			randomTankButton.Font = buttonFont;
			twoOfEachButton.Font = buttonFont;
			singleHeroLabel.Font = singleLabelFont;
		}

		private void randomAnyButton_Click(object sender, EventArgs e)
		{
			WipeAllLabels();
			singleHeroLabel.Text = randomSelection.RandomAny().HeroName;
		}

		private void randomTankButton_Click(object sender, EventArgs e)
		{
			WipeAllLabels();
			singleHeroLabel.Text = randomSelection.RandomTank().HeroName;			
		}

		private void randomHealerButton_Click(object sender, EventArgs e)
		{
			WipeAllLabels();
			singleHeroLabel.Text = randomSelection.RandomSupport().HeroName;
		}

		private void randomDamageButton_Click(object sender, EventArgs e)
		{
			WipeAllLabels();
			singleHeroLabel.Text = randomSelection.RandomDamage().HeroName;
		}

		private void twoOfEachButton_Click(object sender, EventArgs e)
		{
			WipeAllLabels();
			List<HeroModel> twoOfEach = randomSelection.RandomTwoOfEach();
			randomTankOneLabel.Text = twoOfEach[0].HeroName;
			randomTankTwoLabel.Text = twoOfEach[1].HeroName;
			randomSupportOneLabel.Text = twoOfEach[2].HeroName;
			randomSupportTwoLabel.Text = twoOfEach[3].HeroName;
			randomDamageOneLabel.Text = twoOfEach[4].HeroName;
			randomDamageTwoLabel.Text = twoOfEach[5].HeroName;
		}

		private void WipeAllLabels()
		{
			singleHeroLabel.Text = "";
			randomTankOneLabel.Text = "";
			randomTankTwoLabel.Text = "";
			randomSupportOneLabel.Text = "";
			randomSupportTwoLabel.Text = "";
			randomDamageOneLabel.Text = "";
			randomDamageTwoLabel.Text = "";
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

		private void PanelHoverColor(object sender, EventArgs e)
		{
			Panel pnl = sender as Panel;
			pnl.BackColor = hoverColor;
		}

		private void PanelDefaultColor(object sender, EventArgs e)
		{
			Panel pnl = sender as Panel;
			pnl.BackColor = backColor;
		}

		private void closeButton_MouseClick(object sender, MouseEventArgs e)
		{
			Application.Exit();
		}

		private void minimizeButton_MouseClick(object sender, MouseEventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}		
	}
}

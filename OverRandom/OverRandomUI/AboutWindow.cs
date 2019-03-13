using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverRandomUI
{
	public partial class AboutWindow : Form
	{
		Color hoverColor = ColorTranslator.FromHtml("#FF8900");
		Color backColor = ColorTranslator.FromHtml("#333333");

		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
			IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

		private PrivateFontCollection fonts = new PrivateFontCollection();

		Font headerFont;
		Font labelFont;

		public AboutWindow()
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
			labelFont = new Font(fonts.Families[0], 20.0F);
		}

		private void closeButton_MouseEnter(object sender, EventArgs e)
		{
			Panel pnl = sender as Panel;
			pnl.BackColor = hoverColor;
		}

		private void closeButton_MouseLeave(object sender, EventArgs e)
		{
			Panel pnl = sender as Panel;
			pnl.BackColor = backColor;
		}

		private void closeButton_MouseClick(object sender, MouseEventArgs e)
		{
			this.Close();
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

		private void AboutWindow_Load(object sender, EventArgs e)
		{
			aboutHeaderLabel.Font = labelFont;
		}
	}
}

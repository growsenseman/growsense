using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroSuite;

namespace TrainerBase
{
	public partial class dikdkdkd : Form
	{
		public dikdkdkd()
		{
			this.InitializeComponent();
		}

		private void metroButton16_Click(object sender, EventArgs e)
		{
			base.Hide();
			TrainerBase ug = new TrainerBase();
			ug.Show();
		}

		private void dikdkdkd_Load(object sender, EventArgs e)
		{
			string fontName = "Century Gothic";
			float fontSize = 12f;
			using (Font fontTester = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel))
			{
				bool flag = fontTester.Name == fontName;
				if (!flag)
				{
					MessageBox.Show("Please install the century gothic font from growsense folder before using the program.");
					Environment.Exit(0);
				}
			}
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}

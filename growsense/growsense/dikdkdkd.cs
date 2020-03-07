using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroSuite;

namespace TrainerBase
{
	// Token: 0x02000002 RID: 2
	public partial class dikdkdkd : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public dikdkdkd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		private void metroButton16_Click(object sender, EventArgs e)
		{
			base.Hide();
			TrainerBase ug = new TrainerBase();
			ug.Show();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002084 File Offset: 0x00000284
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

		// Token: 0x06000004 RID: 4 RVA: 0x000020F0 File Offset: 0x000002F0
		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020F3 File Offset: 0x000002F3
		private void label2_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}

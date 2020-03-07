using System;
using System.Windows.Forms;

namespace TrainerBase
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00018EAA File Offset: 0x000170AA
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TrainerBase());
		}
	}
}

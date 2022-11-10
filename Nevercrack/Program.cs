using System;
using System.Windows.Forms;
using Leaf.xNet;

namespace Nevercrack
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000020AF File Offset: 0x000002AF
		[STAThread]
		private static void Main()
		{
			new HttpException().ToString();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Loading());
		}
	}
}

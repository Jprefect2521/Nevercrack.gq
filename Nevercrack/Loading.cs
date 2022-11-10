using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace Nevercrack
{
	// Token: 0x02000002 RID: 2
	public partial class Loading : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Loading()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002104 File Offset: 0x00000304
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			base.Hide();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		private void Loading_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002128 File Offset: 0x00000328
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.guna2ProgressBar1.Increment(3);
			bool flag = this.guna2ProgressBar1.Value >= this.guna2ProgressBar1.Maximum;
			if (flag)
			{
				this.timer1.Stop();
				Form1 form = new Form1();
				form.Show();
				base.Hide();
			}
		}
	}
}

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Nevercrack.Properties;

namespace Nevercrack
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002077 File Offset: 0x00000277
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000208F File Offset: 0x0000028F
		private void Form1_Load(object sender, EventArgs e)
		{
			this.label4.Visible = false;
			this.guna2ProgressBar1.Visible = false;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020AC File Offset: 0x000002AC
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002558 File Offset: 0x00000758
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.guna2Button1.Visible = false;
			this.label2.Visible = false;
			this.label3.Visible = false;
			this.guna2GroupBox1.Visible = false;
			this.guna2GroupBox2.Visible = false;
			this.label4.Visible = true;
			this.guna2ProgressBar1.Visible = true;
			this.timer1.Start();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000025D0 File Offset: 0x000007D0
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.guna2ProgressBar1.Increment(2);
			bool flag = this.guna2ProgressBar1.Value >= this.guna2ProgressBar1.Maximum;
			if (flag)
			{
				this.timer1.Stop();
				Process.Start("steam://rungameid/730");
				Application.Exit();
			}
		}
	}
}

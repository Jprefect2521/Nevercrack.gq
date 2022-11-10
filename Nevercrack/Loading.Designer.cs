namespace Nevercrack
{
	// Token: 0x02000002 RID: 2
	public partial class Loading : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002184 File Offset: 0x00000384
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021BC File Offset: 0x000003BC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Nevercrack.Loading));
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2CirclePictureBox1 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2ProgressBar1 = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.guna2Elipse1.TargetControl = this;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Verdana", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Transparent;
			this.label1.Location = new global::System.Drawing.Point(0xD1, 0xF);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0xBA, 0x17);
			this.label1.TabIndex = 2;
			this.label1.Text = "NC - NeverCrack";
			this.guna2CirclePictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("guna2CirclePictureBox1.Image");
			this.guna2CirclePictureBox1.ImageRotate = 0f;
			this.guna2CirclePictureBox1.Location = new global::System.Drawing.Point(0xAB, 0xC);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new global::System.Drawing.Size(0x29, 0x1C);
			this.guna2CirclePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2CirclePictureBox1.TabIndex = 9;
			this.guna2CirclePictureBox1.TabStop = false;
			this.guna2ProgressBar1.Location = new global::System.Drawing.Point(0, 0x5B);
			this.guna2ProgressBar1.Name = "guna2ProgressBar1";
			this.guna2ProgressBar1.ProgressColor = global::System.Drawing.Color.FromArgb(6, 0x16, 0x23);
			this.guna2ProgressBar1.ProgressColor2 = global::System.Drawing.Color.FromArgb(6, 0x16, 0x23);
			this.guna2ProgressBar1.Size = new global::System.Drawing.Size(0x224, 0x1E);
			this.guna2ProgressBar1.TabIndex = 0xA;
			this.guna2ProgressBar1.Text = "guna2ProgressBar1";
			this.guna2ProgressBar1.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(2, 0xC, 0x19);
			base.ClientSize = new global::System.Drawing.Size(0x223, 0x7B);
			base.Controls.Add(this.guna2ProgressBar1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2CirclePictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Loading";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Eula";
			base.Load += new global::System.EventHandler(this.Loading_Load);
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000003 RID: 3
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000005 RID: 5
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;

		// Token: 0x04000006 RID: 6
		private global::Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Timer timer1;
	}
}

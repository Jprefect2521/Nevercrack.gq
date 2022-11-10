namespace Nevercrack
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000262C File Offset: 0x0000082C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002664 File Offset: 0x00000864
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Nevercrack.Form1));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2GroupBox1 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.guna2GroupBox2 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.richTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.guna2ProgressBar1 = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.label4 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2CirclePictureBox1 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2Panel1.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			this.guna2GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2Elipse1.TargetControl = this;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.TargetControl = this.guna2Panel1;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.guna2Panel1.BackColor = global::System.Drawing.Color.FromArgb(6, 0x16, 0x23);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
			this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
			this.guna2Panel1.Location = new global::System.Drawing.Point(-0xB, -0xB);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(0x34F, 0x2A);
			this.guna2Panel1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Impact", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Transparent;
			this.label1.Location = new global::System.Drawing.Point(0x161, 0xD);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0x85, 0x17);
			this.label1.TabIndex = 1;
			this.label1.Text = "NC - NeverCrack";
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(0x31A, 0xB);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(0x1E, 0x1E);
			this.guna2ControlBox1.TabIndex = 4;
			this.guna2ControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox2.ControlBoxType = global::Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox2.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new global::System.Drawing.Point(0x2FB, 0xB);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new global::System.Drawing.Size(0x1E, 0x1E);
			this.guna2ControlBox2.TabIndex = 3;
			this.guna2Button1.Animated = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.FromArgb(4, 0xC, 0x1C);
			this.guna2Button1.BackgroundImage = global::Nevercrack.Properties.Resources.e54029b9525dd7ca11296572d52edae5bccb13a4;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 0xC;
			this.guna2Button1.BorderThickness = 2;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(0xA9, 0xA9, 0xA9);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(0x8D, 0x8D, 0x8D);
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 0x9F, 0x91);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.Location = new global::System.Drawing.Point(0x31, 0x163);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(0x2C6, 0x2D);
			this.guna2Button1.TabIndex = 1;
			this.guna2Button1.Text = "Inject";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2GroupBox1.BorderColor = global::System.Drawing.Color.FromArgb(6, 0x16, 0x23);
			this.guna2GroupBox1.BorderRadius = 5;
			this.guna2GroupBox1.BorderThickness = 2;
			this.guna2GroupBox1.Controls.Add(this.richTextBox1);
			this.guna2GroupBox1.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.guna2GroupBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2GroupBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GroupBox1.ForeColor = global::System.Drawing.Color.FromArgb(0x7D, 0x89, 0x95);
			this.guna2GroupBox1.Location = new global::System.Drawing.Point(0x31, 0x5B);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new global::System.Drawing.Size(0x15B, 0xC8);
			this.guna2GroupBox1.TabIndex = 2;
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(2, 0xC, 0x19);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new global::System.Drawing.Font("Verdana", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(0x7F, 0x8F, 0x90);
			this.richTextBox1.Location = new global::System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(0x14B, 0xB7);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "NeverCrack will allow you to\n\ncompletely change the look of the\ngame to your liking.\n\nChange skins for weapons, turn on\nnight mode or simply repaint the walls\neverything to your taste!";
			this.richTextBox1.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
			this.guna2GroupBox2.BorderColor = global::System.Drawing.Color.FromArgb(6, 0x16, 0x23);
			this.guna2GroupBox2.BorderRadius = 5;
			this.guna2GroupBox2.BorderThickness = 2;
			this.guna2GroupBox2.Controls.Add(this.richTextBox2);
			this.guna2GroupBox2.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.guna2GroupBox2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2GroupBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GroupBox2.ForeColor = global::System.Drawing.Color.FromArgb(0x7D, 0x89, 0x95);
			this.guna2GroupBox2.Location = new global::System.Drawing.Point(0x19C, 0x5B);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new global::System.Drawing.Size(0x15B, 0xC8);
			this.guna2GroupBox2.TabIndex = 3;
			this.richTextBox2.BackColor = global::System.Drawing.Color.FromArgb(2, 0xC, 0x19);
			this.richTextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Font = new global::System.Drawing.Font("Verdana", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox2.ForeColor = global::System.Drawing.Color.FromArgb(0x7F, 0x8F, 0x90);
			this.richTextBox2.Location = new global::System.Drawing.Point(8, 9);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new global::System.Drawing.Size(0x14B, 0xB7);
			this.richTextBox2.TabIndex = 1;
			this.richTextBox2.Text = "Neverlose Crack for CS:GO!\n\nInject & play..";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Verdana", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Transparent;
			this.label2.Location = new global::System.Drawing.Point(0x34, 0x46);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0x69, 0x12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Description:";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Verdana", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Transparent;
			this.label3.Location = new global::System.Drawing.Point(0x1A2, 0x46);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(0x30, 0x12);
			this.label3.TabIndex = 5;
			this.label3.Text = "Info:";
			this.guna2ProgressBar1.BorderRadius = 2;
			this.guna2ProgressBar1.Location = new global::System.Drawing.Point(0x10, 0x7E);
			this.guna2ProgressBar1.Name = "guna2ProgressBar1";
			this.guna2ProgressBar1.ProgressColor = global::System.Drawing.Color.FromArgb(6, 0x16, 0x23);
			this.guna2ProgressBar1.ProgressColor2 = global::System.Drawing.Color.FromArgb(6, 0x16, 0x23);
			this.guna2ProgressBar1.Size = new global::System.Drawing.Size(0x30C, 0x1E);
			this.guna2ProgressBar1.TabIndex = 6;
			this.guna2ProgressBar1.Text = "guna2ProgressBar1";
			this.guna2ProgressBar1.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Verdana", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Transparent;
			this.label4.Location = new global::System.Drawing.Point(0x13, 0x6A);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(0x52, 0x12);
			this.label4.TabIndex = 7;
			this.label4.Text = "Loading..";
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.guna2CirclePictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("guna2CirclePictureBox1.Image");
			this.guna2CirclePictureBox1.ImageRotate = 0f;
			this.guna2CirclePictureBox1.Location = new global::System.Drawing.Point(0x308, 0x25);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new global::System.Drawing.Size(0x29, 0x1C);
			this.guna2CirclePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2CirclePictureBox1.TabIndex = 8;
			this.guna2CirclePictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(2, 0xC, 0x19);
			this.BackgroundImage = global::Nevercrack.Properties.Resources.e54029b9525dd7ca11296572d52edae5bccb13a4;
			base.ClientSize = new global::System.Drawing.Size(0x32E, 0x1AB);
			base.Controls.Add(this.guna2CirclePictureBox1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.guna2ProgressBar1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.guna2GroupBox2);
			base.Controls.Add(this.guna2GroupBox1);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.guna2Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NeverCrack";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000009 RID: 9
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x0400000A RID: 10
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400000B RID: 11
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000D RID: 13
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400000E RID: 14
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x0400000F RID: 15
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000010 RID: 16
		private global::Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000013 RID: 19
		private global::Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.RichTextBox richTextBox2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000017 RID: 23
		private global::Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000019 RID: 25
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
	}
}

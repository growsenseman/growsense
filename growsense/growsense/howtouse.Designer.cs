namespace TrainerBase
{
	// Token: 0x02000006 RID: 6
	public partial class howtouse : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x000188F0 File Offset: 0x00016AF0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00018928 File Offset: 0x00016B28
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TrainerBase.howtouse));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl3 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 11.25f);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(86, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Help page";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Century Gothic", 11.25f);
			this.label2.Location = new global::System.Drawing.Point(457, 9);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(18, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "X";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Century Gothic", 9.25f);
			this.label3.Location = new global::System.Drawing.Point(13, 39);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(382, 68);
			this.label3.TabIndex = 2;
			this.label3.Text = "1. Open \"open first\" and click the button.\r\n2. Open growtopia (before the trainer)\r\n3. Open trainer (if you got no message you're fine)\r\n4. You should be able to use the trainer without problems.";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Century Gothic", 9.25f);
			this.label4.Location = new global::System.Drawing.Point(13, 146);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(0, 17);
			this.label4.TabIndex = 4;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Century Gothic", 9.25f);
			this.label5.Location = new global::System.Drawing.Point(13, 144);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(428, 187);
			this.label5.TabIndex = 6;
			this.label5.Text = resources.GetString("label5.Text");
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Century Gothic", 11.25f);
			this.label6.Location = new global::System.Drawing.Point(12, 114);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(121, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Common errors";
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.label5;
			this.bunifuDragControl2.Vertical = true;
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = this.label3;
			this.bunifuDragControl3.Vertical = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 17f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(487, 526);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.Font = new global::System.Drawing.Font("Century Gothic", 9.25f);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "howtouse";
			this.Text = "howtouse";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001AC RID: 428
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001B1 RID: 433
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001B4 RID: 436
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040001B5 RID: 437
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
	}
}

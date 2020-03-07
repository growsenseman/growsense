namespace TrainerBase
{
	public partial class dikdkdkd : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TrainerBase.dikdkdkd));
			this.metroButton16 = new global::MetroSuite.MetroButton();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.dateTimePicker1 = new global::System.Windows.Forms.DateTimePicker();
			this.bunifuDragControl3 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.metroButton16.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroButton16.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.metroButton16.BorderColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroButton16.DefaultColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroButton16.DisabledColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroButton16.Font = new global::System.Drawing.Font("Century Gothic", 9.75f);
			this.metroButton16.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.metroButton16.HoverColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroButton16.Location = new global::System.Drawing.Point(62, 129);
			this.metroButton16.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.metroButton16.Name = "metroButton16";
			this.metroButton16.PressedColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.metroButton16.RoundingArc = 30;
			this.metroButton16.Size = new global::System.Drawing.Size(329, 30);
			this.metroButton16.TabIndex = 103;
			this.metroButton16.Text = "Log in";
			this.metroButton16.Click += new global::System.EventHandler(this.metroButton16_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = null;
			this.bunifuDragControl2.Vertical = true;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 10.75f);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(208, 20);
			this.label1.TabIndex = 120;
			this.label1.Text = "GrowSense Login v1.0 Beta";
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new global::System.Drawing.Point(187, 1783);
			this.dateTimePicker1.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new global::System.Drawing.Size(201, 23);
			this.dateTimePicker1.TabIndex = 123;
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = null;
			this.bunifuDragControl3.Vertical = true;
			this.txtPassword.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.txtPassword.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new global::System.Drawing.Font("Century Gothic", 9.75f);
			this.txtPassword.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.txtPassword.Location = new global::System.Drawing.Point(62, 96);
			this.txtPassword.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(329, 27);
			this.txtPassword.TabIndex = 122;
			this.txtPassword.TextChanged += new global::System.EventHandler(this.txtPassword_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Century Gothic", 10.75f);
			this.label2.Location = new global::System.Drawing.Point(421, 9);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(18, 20);
			this.label2.TabIndex = 124;
			this.label2.Text = "X";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(12, 12, 12);
			base.ClientSize = new global::System.Drawing.Size(451, 231);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.dateTimePicker1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.metroButton16);
			this.Font = new global::System.Drawing.Font("Montserrat", 9.25f);
			this.ForeColor = global::System.Drawing.Color.Gainsboro;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "dikdkdkd";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "growsense";
			base.Load += new global::System.EventHandler(this.dikdkdkd_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::MetroSuite.MetroButton metroButton16;

		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.DateTimePicker dateTimePicker1;

		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;

		private global::System.Windows.Forms.TextBox txtPassword;

		private global::System.Windows.Forms.Label label2;
	}
}

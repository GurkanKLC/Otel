/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 02.06.2020
 * Time: 19:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Otel
{
	partial class odabilgiler
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odabilgiler));
			this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
			this.bunifuSeparator1 = new ns1.BunifuSeparator();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bunifuiOSSwitch1
			// 
			this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
			this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuiOSSwitch1.Location = new System.Drawing.Point(389, 41);
			this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
			this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
			this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
			this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
			this.bunifuiOSSwitch1.TabIndex = 35;
			this.bunifuiOSSwitch1.Value = false;
			this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.BunifuiOSSwitch1OnValueChange);
			this.bunifuiOSSwitch1.Click += new System.EventHandler(this.BunifuiOSSwitch1Click);
			// 
			// bunifuSeparator1
			// 
			this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.bunifuSeparator1.LineThickness = 1;
			this.bunifuSeparator1.Location = new System.Drawing.Point(10, 65);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Size = new System.Drawing.Size(414, 10);
			this.bunifuSeparator1.TabIndex = 34;
			this.bunifuSeparator1.Transparency = 255;
			this.bunifuSeparator1.Vertical = false;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(294, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 23);
			this.label6.TabIndex = 33;
			this.label6.Text = "label6";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(198, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 23);
			this.label5.TabIndex = 32;
			this.label5.Text = "label5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(69, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 31;
			this.label3.Text = "Oda No";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(126, 38);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 26);
			this.label10.TabIndex = 27;
			this.label10.Text = "Kişi Sayısı";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(242, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 26);
			this.label4.TabIndex = 28;
			this.label4.Text = "Gün";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(7, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 26);
			this.label1.TabIndex = 25;
			this.label1.Text = "Oda no";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Enabled = false;
			this.dateTimePicker2.Location = new System.Drawing.Point(218, 107);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
			this.dateTimePicker2.TabIndex = 30;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2ValueChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(13, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(182, 26);
			this.label7.TabIndex = 26;
			this.label7.Text = "Giriş Tarihi";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new System.Drawing.Point(13, 108);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
			this.dateTimePicker1.TabIndex = 29;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(218, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(182, 26);
			this.label8.TabIndex = 24;
			this.label8.Text = "Çıkış Tarihi";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuFlatButton3
			// 
			this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "Çıkış";
			this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = true;
			this.bunifuFlatButton3.IconRightZoom = 0D;
			this.bunifuFlatButton3.IconVisible = true;
			this.bunifuFlatButton3.IconZoom = 70D;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new System.Drawing.Point(278, 156);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton3.TabIndex = 44;
			this.bunifuFlatButton3.Text = "Çıkış";
			this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(13, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 26);
			this.label2.TabIndex = 45;
			this.label2.Text = "Kira Bilgileri";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// odabilgiler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
			this.ClientSize = new System.Drawing.Size(439, 212);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bunifuFlatButton3);
			this.Controls.Add(this.bunifuiOSSwitch1);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "odabilgiler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "odabilgiler";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OdabilgilerMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OdabilgilerMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OdabilgilerMouseUp);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private ns1.BunifuFlatButton bunifuFlatButton3;
		private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private ns1.BunifuSeparator bunifuSeparator1;
	}
}

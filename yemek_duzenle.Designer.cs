/*
 * Created by SharpDevelop.
 * User: G95
 * Date: 5.06.2020
 * Time: 19:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Otel
{
	partial class yemek_duzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yemek_duzenle));
			this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
			this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox3 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox4 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox5 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox6 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
			this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
			this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
			this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
			this.SuspendLayout();
			// 
			// bunifuCustomLabel7
			// 
			this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel7.Location = new System.Drawing.Point(9, 228);
			this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
			this.bunifuCustomLabel7.Size = new System.Drawing.Size(65, 22);
			this.bunifuCustomLabel7.TabIndex = 40;
			this.bunifuCustomLabel7.Text = "Besin Ara :";
			this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(48, 66);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(475, 133);
			this.listView1.TabIndex = 35;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 9);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(170, 32);
			this.bunifuCustomLabel1.TabIndex = 34;
			this.bunifuCustomLabel1.Text = "Besin Stok Ekranı";
			this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(339, 328);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(65, 22);
			this.bunifuCustomLabel5.TabIndex = 29;
			this.bunifuCustomLabel5.Text = "Adet :";
			this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(339, 270);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(65, 22);
			this.bunifuCustomLabel4.TabIndex = 28;
			this.bunifuCustomLabel4.Text = "Ücret :";
			this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 328);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(65, 22);
			this.bunifuCustomLabel3.TabIndex = 27;
			this.bunifuCustomLabel3.Text = "Kalori :";
			this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(9, 270);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 22);
			this.bunifuCustomLabel2.TabIndex = 26;
			this.bunifuCustomLabel2.Text = "Besin Adı :";
			this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuMaterialTextbox2
			// 
			this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.HintText = "Besin Adı";
			this.bunifuMaterialTextbox2.isPassword = false;
			this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(81, 258);
			this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox2.TabIndex = 42;
			this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox3
			// 
			this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.HintText = "Ücret";
			this.bunifuMaterialTextbox3.isPassword = false;
			this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox3.LineThickness = 3;
			this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(411, 258);
			this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
			this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox3.TabIndex = 43;
			this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox4
			// 
			this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.HintText = "Kalari";
			this.bunifuMaterialTextbox4.isPassword = false;
			this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox4.LineThickness = 3;
			this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(81, 310);
			this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
			this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox4.TabIndex = 43;
			this.bunifuMaterialTextbox4.Text = "Kalori";
			this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox5
			// 
			this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.HintText = "Adet";
			this.bunifuMaterialTextbox5.isPassword = false;
			this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox5.LineThickness = 3;
			this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(411, 310);
			this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
			this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox5.TabIndex = 43;
			this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox6
			// 
			this.bunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox6.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.HintText = "Arama";
			this.bunifuMaterialTextbox6.isPassword = false;
			this.bunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox6.LineThickness = 3;
			this.bunifuMaterialTextbox6.Location = new System.Drawing.Point(84, 213);
			this.bunifuMaterialTextbox6.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox6.Name = "bunifuMaterialTextbox6";
			this.bunifuMaterialTextbox6.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox6.TabIndex = 43;
			this.bunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuMaterialTextbox6.OnValueChanged += new System.EventHandler(this.yemekAra);
			// 
			// bunifuMaterialTextbox1
			// 
			this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox1.Enabled = false;
			this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.HintText = "Besin";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(369, 206);
			this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox1.TabIndex = 43;
			this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuMaterialTextbox1.Visible = false;
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "Düzenle";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 70D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(81, 400);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton1.TabIndex = 44;
			this.bunifuFlatButton1.Text = "Düzenle";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1Click);
			// 
			// bunifuFlatButton2
			// 
			this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "Sil";
			this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0D;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 70D;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new System.Drawing.Point(231, 400);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton2.TabIndex = 44;
			this.bunifuFlatButton2.Text = "Sil";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2Click);
			// 
			// bunifuFlatButton3
			// 
			this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
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
			this.bunifuFlatButton3.Location = new System.Drawing.Point(381, 400);
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
			// yemek_duzenle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
			this.ClientSize = new System.Drawing.Size(589, 471);
			this.Controls.Add(this.bunifuFlatButton3);
			this.Controls.Add(this.bunifuFlatButton2);
			this.Controls.Add(this.bunifuFlatButton1);
			this.Controls.Add(this.bunifuMaterialTextbox4);
			this.Controls.Add(this.bunifuMaterialTextbox1);
			this.Controls.Add(this.bunifuMaterialTextbox6);
			this.Controls.Add(this.bunifuMaterialTextbox5);
			this.Controls.Add(this.bunifuMaterialTextbox3);
			this.Controls.Add(this.bunifuMaterialTextbox2);
			this.Controls.Add(this.bunifuCustomLabel7);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.bunifuCustomLabel4);
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "yemek_duzenle";
			this.Text = "yemek_duzenle";
			this.Load += new System.EventHandler(this.Yemek_duzenleLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yemek_duzenleMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Yemek_duzenleMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Yemek_duzenleMouseUp);
			this.ResumeLayout(false);
		}
		private ns1.BunifuFlatButton bunifuFlatButton3;
		private ns1.BunifuFlatButton bunifuFlatButton2;
		private ns1.BunifuFlatButton bunifuFlatButton1;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox6;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox5;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox4;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox3;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
		private ns1.BunifuCustomLabel bunifuCustomLabel2;
		private ns1.BunifuCustomLabel bunifuCustomLabel3;
		private ns1.BunifuCustomLabel bunifuCustomLabel4;
		private ns1.BunifuCustomLabel bunifuCustomLabel5;
		private ns1.BunifuCustomLabel bunifuCustomLabel1;
		private System.Windows.Forms.ListView listView1;
		private ns1.BunifuCustomLabel bunifuCustomLabel7;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
	}
}

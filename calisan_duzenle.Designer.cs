/*
 * Created by SharpDevelop.
 * User: G95
 * Date: 5.06.2020
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Otel
{
	partial class calisan_duzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calisan_duzenle));
			this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
			this.bunifuMetroTextbox1 = new ns1.BunifuMetroTextbox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.label10 = new System.Windows.Forms.Label();
			this.bunifuMaterialTextbox6 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox3 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox4 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox5 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox7 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox8 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox9 = new ns1.BunifuMaterialTextbox();
			this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
			this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
			this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
			this.SuspendLayout();
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(377, 22);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(61, 19);
			this.bunifuCustomLabel1.TabIndex = 48;
			this.bunifuCustomLabel1.Text = "Çalışan Ara";
			// 
			// bunifuMetroTextbox1
			// 
			this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.LightSeaGreen;
			this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.White;
			this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
			this.bunifuMetroTextbox1.BorderThickness = 1;
			this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.White;
			this.bunifuMetroTextbox1.isPassword = false;
			this.bunifuMetroTextbox1.Location = new System.Drawing.Point(445, 9);
			this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
			this.bunifuMetroTextbox1.Size = new System.Drawing.Size(127, 35);
			this.bunifuMetroTextbox1.TabIndex = 47;
			this.bunifuMetroTextbox1.Text = "arama";
			this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuMetroTextbox1.OnValueChanged += new System.EventHandler(this.isimAra);
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(296, 327);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = "Başlangıç Tarihi :";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(332, 296);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 34;
			this.label8.Text = "Pozisyon :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(355, 264);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 16);
			this.label7.TabIndex = 33;
			this.label7.Text = "Maaş :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(342, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 16);
			this.label6.TabIndex = 32;
			this.label6.Text = "Cinsiyet :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 355);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 31;
			this.label5.Text = "Numara :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(11, 322);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 16);
			this.label4.TabIndex = 30;
			this.label4.Text = "Tc Kimlik :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 296);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 29;
			this.label3.Text = "Soyad :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(35, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 28;
			this.label2.Text = "Ad :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(34, 231);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 16);
			this.label1.TabIndex = 27;
			this.label1.Text = "ID :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(12, 54);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(570, 135);
			this.listView1.TabIndex = 26;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(13, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(220, 38);
			this.label10.TabIndex = 49;
			this.label10.Text = "Çalışan Düzenleme";
			// 
			// bunifuMaterialTextbox6
			// 
			this.bunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox6.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.HintText = "İd";
			this.bunifuMaterialTextbox6.isPassword = false;
			this.bunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox6.LineThickness = 3;
			this.bunifuMaterialTextbox6.Location = new System.Drawing.Point(73, 219);
			this.bunifuMaterialTextbox6.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox6.Name = "bunifuMaterialTextbox6";
			this.bunifuMaterialTextbox6.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox6.TabIndex = 50;
			this.bunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox1
			// 
			this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.HintText = "Ad";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(75, 252);
			this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox1.TabIndex = 50;
			this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox2
			// 
			this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.HintText = "Soyad";
			this.bunifuMaterialTextbox2.isPassword = false;
			this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(76, 285);
			this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox2.TabIndex = 50;
			this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox3
			// 
			this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.HintText = "Kimlik No";
			this.bunifuMaterialTextbox3.isPassword = false;
			this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox3.LineThickness = 3;
			this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(76, 319);
			this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
			this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox3.TabIndex = 50;
			this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox4
			// 
			this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.HintText = "Numara";
			this.bunifuMaterialTextbox4.isPassword = false;
			this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox4.LineThickness = 3;
			this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(76, 351);
			this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
			this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox4.TabIndex = 50;
			this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox5
			// 
			this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.HintText = "Cinsiyet";
			this.bunifuMaterialTextbox5.isPassword = false;
			this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox5.LineThickness = 3;
			this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(398, 219);
			this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
			this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox5.TabIndex = 50;
			this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox7
			// 
			this.bunifuMaterialTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox7.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox7.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox7.HintText = "Maaş";
			this.bunifuMaterialTextbox7.isPassword = false;
			this.bunifuMaterialTextbox7.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox7.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox7.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox7.LineThickness = 3;
			this.bunifuMaterialTextbox7.Location = new System.Drawing.Point(398, 252);
			this.bunifuMaterialTextbox7.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox7.Name = "bunifuMaterialTextbox7";
			this.bunifuMaterialTextbox7.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox7.TabIndex = 50;
			this.bunifuMaterialTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox8
			// 
			this.bunifuMaterialTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox8.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox8.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox8.HintText = "Pozisyon";
			this.bunifuMaterialTextbox8.isPassword = false;
			this.bunifuMaterialTextbox8.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox8.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox8.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox8.LineThickness = 3;
			this.bunifuMaterialTextbox8.Location = new System.Drawing.Point(398, 284);
			this.bunifuMaterialTextbox8.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox8.Name = "bunifuMaterialTextbox8";
			this.bunifuMaterialTextbox8.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox8.TabIndex = 50;
			this.bunifuMaterialTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox9
			// 
			this.bunifuMaterialTextbox9.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox9.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox9.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox9.HintText = "Tarih";
			this.bunifuMaterialTextbox9.isPassword = false;
			this.bunifuMaterialTextbox9.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox9.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox9.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox9.LineThickness = 3;
			this.bunifuMaterialTextbox9.Location = new System.Drawing.Point(398, 319);
			this.bunifuMaterialTextbox9.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox9.Name = "bunifuMaterialTextbox9";
			this.bunifuMaterialTextbox9.Size = new System.Drawing.Size(154, 28);
			this.bunifuMaterialTextbox9.TabIndex = 50;
			this.bunifuMaterialTextbox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.bunifuFlatButton1.Location = new System.Drawing.Point(75, 409);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton1.TabIndex = 51;
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
			this.bunifuFlatButton2.ButtonText = "Sırala";
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
			this.bunifuFlatButton2.Location = new System.Drawing.Point(232, 409);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton2.TabIndex = 52;
			this.bunifuFlatButton2.Text = "Sırala";
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
			this.bunifuFlatButton3.Location = new System.Drawing.Point(387, 409);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton3.TabIndex = 53;
			this.bunifuFlatButton3.Text = "Çıkış";
			this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3Click);
			// 
			// calisan_duzenle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
			this.ClientSize = new System.Drawing.Size(596, 488);
			this.Controls.Add(this.bunifuFlatButton3);
			this.Controls.Add(this.bunifuFlatButton2);
			this.Controls.Add(this.bunifuFlatButton1);
			this.Controls.Add(this.bunifuMaterialTextbox9);
			this.Controls.Add(this.bunifuMaterialTextbox8);
			this.Controls.Add(this.bunifuMaterialTextbox7);
			this.Controls.Add(this.bunifuMaterialTextbox5);
			this.Controls.Add(this.bunifuMaterialTextbox4);
			this.Controls.Add(this.bunifuMaterialTextbox3);
			this.Controls.Add(this.bunifuMaterialTextbox2);
			this.Controls.Add(this.bunifuMaterialTextbox1);
			this.Controls.Add(this.bunifuMaterialTextbox6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.bunifuMetroTextbox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "calisan_duzenle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "calisan_duzenle";
			this.Load += new System.EventHandler(this.Calisan_duzenleLoad);
			this.ResumeLayout(false);
		}
		private ns1.BunifuFlatButton bunifuFlatButton3;
		private ns1.BunifuFlatButton bunifuFlatButton2;
		private ns1.BunifuFlatButton bunifuFlatButton1;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox9;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox8;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox7;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox5;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox4;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox3;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private ns1.BunifuMetroTextbox bunifuMetroTextbox1;
		private ns1.BunifuCustomLabel bunifuCustomLabel1;
	}
}

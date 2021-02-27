/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 05.06.2020
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Otel
{
	partial class aktifmusteri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aktifmusteri));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuiOSSwitch1 = new ns1.BunifuiOSSwitch();
			this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
			this.bunifuiOSSwitch2 = new ns1.BunifuiOSSwitch();
			this.bunifuiOSSwitch3 = new ns1.BunifuiOSSwitch();
			this.bunifuiOSSwitch4 = new ns1.BunifuiOSSwitch();
			this.bunifuiOSSwitch5 = new ns1.BunifuiOSSwitch();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox6 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
			this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(12, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 340);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(293, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Aktif";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bunifuiOSSwitch1
			// 
			this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
			this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuiOSSwitch1.Location = new System.Drawing.Point(244, 77);
			this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
			this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.SkyBlue;
			this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
			this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
			this.bunifuiOSSwitch1.TabIndex = 2;
			this.bunifuiOSSwitch1.Value = true;
			this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.BunifuiOSSwitch1OnValueChange);
			// 
			// bunifuMaterialTextbox1
			// 
			this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
			this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox1.HintText = "Arama";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(244, 231);
			this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(172, 44);
			this.bunifuMaterialTextbox1.TabIndex = 3;
			this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuiOSSwitch2
			// 
			this.bunifuiOSSwitch2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuiOSSwitch2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch2.BackgroundImage")));
			this.bunifuiOSSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuiOSSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuiOSSwitch2.Location = new System.Drawing.Point(244, 108);
			this.bunifuiOSSwitch2.Name = "bunifuiOSSwitch2";
			this.bunifuiOSSwitch2.OffColor = System.Drawing.Color.Gray;
			this.bunifuiOSSwitch2.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
			this.bunifuiOSSwitch2.Size = new System.Drawing.Size(43, 25);
			this.bunifuiOSSwitch2.TabIndex = 6;
			this.bunifuiOSSwitch2.Value = false;
			this.bunifuiOSSwitch2.OnValueChange += new System.EventHandler(this.BunifuiOSSwitch2OnValueChange);
			// 
			// bunifuiOSSwitch3
			// 
			this.bunifuiOSSwitch3.BackColor = System.Drawing.Color.Transparent;
			this.bunifuiOSSwitch3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch3.BackgroundImage")));
			this.bunifuiOSSwitch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuiOSSwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuiOSSwitch3.Location = new System.Drawing.Point(243, 139);
			this.bunifuiOSSwitch3.Name = "bunifuiOSSwitch3";
			this.bunifuiOSSwitch3.OffColor = System.Drawing.Color.Gray;
			this.bunifuiOSSwitch3.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
			this.bunifuiOSSwitch3.Size = new System.Drawing.Size(43, 25);
			this.bunifuiOSSwitch3.TabIndex = 6;
			this.bunifuiOSSwitch3.Value = false;
			this.bunifuiOSSwitch3.OnValueChange += new System.EventHandler(this.BunifuiOSSwitch3OnValueChange);
			// 
			// bunifuiOSSwitch4
			// 
			this.bunifuiOSSwitch4.BackColor = System.Drawing.Color.Transparent;
			this.bunifuiOSSwitch4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch4.BackgroundImage")));
			this.bunifuiOSSwitch4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuiOSSwitch4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuiOSSwitch4.Location = new System.Drawing.Point(244, 170);
			this.bunifuiOSSwitch4.Name = "bunifuiOSSwitch4";
			this.bunifuiOSSwitch4.OffColor = System.Drawing.Color.Gray;
			this.bunifuiOSSwitch4.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
			this.bunifuiOSSwitch4.Size = new System.Drawing.Size(43, 25);
			this.bunifuiOSSwitch4.TabIndex = 6;
			this.bunifuiOSSwitch4.Value = false;
			this.bunifuiOSSwitch4.OnValueChange += new System.EventHandler(this.BunifuiOSSwitch4OnValueChange);
			// 
			// bunifuiOSSwitch5
			// 
			this.bunifuiOSSwitch5.BackColor = System.Drawing.Color.Transparent;
			this.bunifuiOSSwitch5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch5.BackgroundImage")));
			this.bunifuiOSSwitch5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuiOSSwitch5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuiOSSwitch5.Location = new System.Drawing.Point(243, 201);
			this.bunifuiOSSwitch5.Name = "bunifuiOSSwitch5";
			this.bunifuiOSSwitch5.OffColor = System.Drawing.Color.Gray;
			this.bunifuiOSSwitch5.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
			this.bunifuiOSSwitch5.Size = new System.Drawing.Size(43, 25);
			this.bunifuiOSSwitch5.TabIndex = 6;
			this.bunifuiOSSwitch5.Value = false;
			this.bunifuiOSSwitch5.OnValueChange += new System.EventHandler(this.BunifuiOSSwitch5OnValueChange);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(293, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "İsme Göre";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(293, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Soyisme Göre";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(293, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Kimlik NO";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(292, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Telefon";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bunifuMaterialTextbox2
			// 
			this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox2.Enabled = false;
			this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox2.HintText = "";
			this.bunifuMaterialTextbox2.isPassword = false;
			this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(451, 63);
			this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox2.MaxLength = 32767;
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(221, 41);
			this.bunifuMaterialTextbox2.TabIndex = 7;
			this.bunifuMaterialTextbox2.Text = "İsim";
			this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bunifuMaterialTextbox3
			// 
			this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox3.Enabled = false;
			this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox3.HintText = "";
			this.bunifuMaterialTextbox3.isPassword = false;
			this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox3.LineThickness = 3;
			this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(451, 107);
			this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox3.MaxLength = 32767;
			this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
			this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(221, 41);
			this.bunifuMaterialTextbox3.TabIndex = 7;
			this.bunifuMaterialTextbox3.Text = "Soyisim";
			this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bunifuMaterialTextbox4
			// 
			this.bunifuMaterialTextbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.bunifuMaterialTextbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.bunifuMaterialTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox4.Enabled = false;
			this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox4.HintText = "";
			this.bunifuMaterialTextbox4.isPassword = false;
			this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox4.LineThickness = 3;
			this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(451, 152);
			this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox4.MaxLength = 32767;
			this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
			this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(221, 41);
			this.bunifuMaterialTextbox4.TabIndex = 7;
			this.bunifuMaterialTextbox4.Text = "Telefon";
			this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bunifuMaterialTextbox5
			// 
			this.bunifuMaterialTextbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.bunifuMaterialTextbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.bunifuMaterialTextbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox5.Enabled = false;
			this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox5.HintText = "";
			this.bunifuMaterialTextbox5.isPassword = false;
			this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox5.LineThickness = 3;
			this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(451, 195);
			this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox5.MaxLength = 32767;
			this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
			this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(221, 41);
			this.bunifuMaterialTextbox5.TabIndex = 7;
			this.bunifuMaterialTextbox5.Text = "Kimlik No";
			this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bunifuMaterialTextbox6
			// 
			this.bunifuMaterialTextbox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.bunifuMaterialTextbox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.bunifuMaterialTextbox6.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.bunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox6.Enabled = false;
			this.bunifuMaterialTextbox6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox6.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox6.HintText = "";
			this.bunifuMaterialTextbox6.isPassword = false;
			this.bunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox6.LineThickness = 3;
			this.bunifuMaterialTextbox6.Location = new System.Drawing.Point(451, 240);
			this.bunifuMaterialTextbox6.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox6.MaxLength = 32767;
			this.bunifuMaterialTextbox6.Name = "bunifuMaterialTextbox6";
			this.bunifuMaterialTextbox6.Size = new System.Drawing.Size(221, 41);
			this.bunifuMaterialTextbox6.TabIndex = 7;
			this.bunifuMaterialTextbox6.Text = "Oda No";
			this.bunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new System.Drawing.Point(466, 318);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Enabled = false;
			this.dateTimePicker2.Location = new System.Drawing.Point(466, 371);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(173, 20);
			this.dateTimePicker2.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(498, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Giriş Tarihi";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(498, 345);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Çıkış Tarihi";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(24, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(169, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Misafir Listesi";
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "Göster";
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
			this.bunifuFlatButton1.Location = new System.Drawing.Point(254, 292);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(151, 48);
			this.bunifuFlatButton1.TabIndex = 24;
			this.bunifuFlatButton1.Text = "Göster";
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
			this.bunifuFlatButton2.ButtonText = "Çıkış";
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
			this.bunifuFlatButton2.Location = new System.Drawing.Point(254, 362);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(151, 48);
			this.bunifuFlatButton2.TabIndex = 24;
			this.bunifuFlatButton2.Text = "Çıkış";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2Click);
			// 
			// aktifmusteri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
			this.ClientSize = new System.Drawing.Size(685, 447);
			this.Controls.Add(this.bunifuFlatButton2);
			this.Controls.Add(this.bunifuFlatButton1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.bunifuMaterialTextbox6);
			this.Controls.Add(this.bunifuMaterialTextbox5);
			this.Controls.Add(this.bunifuMaterialTextbox4);
			this.Controls.Add(this.bunifuMaterialTextbox3);
			this.Controls.Add(this.bunifuMaterialTextbox2);
			this.Controls.Add(this.bunifuiOSSwitch5);
			this.Controls.Add(this.bunifuiOSSwitch4);
			this.Controls.Add(this.bunifuiOSSwitch3);
			this.Controls.Add(this.bunifuiOSSwitch2);
			this.Controls.Add(this.bunifuMaterialTextbox1);
			this.Controls.Add(this.bunifuiOSSwitch1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "aktifmusteri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Telefon";
			this.Load += new System.EventHandler(this.AktifmusteriLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AktifmusteriMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AktifmusteriMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AktifmusteriMouseUp);
			this.ResumeLayout(false);
		}
		private ns1.BunifuFlatButton bunifuFlatButton2;
		private ns1.BunifuFlatButton bunifuFlatButton1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox6;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private ns1.BunifuiOSSwitch bunifuiOSSwitch5;
		private ns1.BunifuiOSSwitch bunifuiOSSwitch4;
		private ns1.BunifuiOSSwitch bunifuiOSSwitch3;
		private ns1.BunifuiOSSwitch bunifuiOSSwitch2;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
		private ns1.BunifuiOSSwitch bunifuiOSSwitch1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}

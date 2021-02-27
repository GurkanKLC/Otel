/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 01.04.2020
 * Time: 13:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Otel
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
			this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
			this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(211, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Giriş";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuMaterialTextbox1
			// 
			this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.HintText = "Kullanıcı Adı";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(183, 79);
			this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox1.TabIndex = 42;
			this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuMaterialTextbox2
			// 
			this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.HintText = "Şifre";
			this.bunifuMaterialTextbox2.isPassword = true;
			this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(183, 150);
			this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(154, 44);
			this.bunifuMaterialTextbox2.TabIndex = 42;
			this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "Giriş";
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
			this.bunifuFlatButton1.Location = new System.Drawing.Point(127, 233);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton1.TabIndex = 43;
			this.bunifuFlatButton1.Text = "Giriş";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1Click);
			// 
			// bunifuFlatButton2
			// 
			this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
			this.bunifuFlatButton2.Location = new System.Drawing.Point(281, 233);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(122, 44);
			this.bunifuFlatButton2.TabIndex = 43;
			this.bunifuFlatButton2.Text = "Çıkış";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(558, 354);
			this.Controls.Add(this.bunifuFlatButton2);
			this.Controls.Add(this.bunifuFlatButton1);
			this.Controls.Add(this.bunifuMaterialTextbox2);
			this.Controls.Add(this.bunifuMaterialTextbox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Otel";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private ns1.BunifuFlatButton bunifuFlatButton2;
		private ns1.BunifuFlatButton bunifuFlatButton1;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
		private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
		private System.Windows.Forms.Label label1;
		
		void MainFormFormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			
		}
	}
}

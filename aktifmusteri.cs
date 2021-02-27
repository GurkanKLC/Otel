/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 05.06.2020
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otel
{
	/// <summary>
	/// Description of aktifmusteri.
	/// </summary>
	public partial class aktifmusteri : Form
	{
		public static string baglanti1="";
		public static string baglanti2="";
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public aktifmusteri()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void musterigoster(object sender,EventArgs e){
			Button tiklanan=(sender as Button);
			char[] ayrac = { '*'};
			string[] parcalar = tiklanan.Text.Split(ayrac);
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			
			OleDbCommand cmd = new OleDbCommand("Select * from musteri where  musteriid=@musteriid",con);
			cmd.Parameters.AddWithValue("@musteriid",parcalar[0].ToString());
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				bunifuMaterialTextbox2.Text=dr["adi"].ToString();
				bunifuMaterialTextbox3.Text=dr["soyadi"].ToString();
				bunifuMaterialTextbox4.Text=dr["telefon"].ToString();
				bunifuMaterialTextbox5.Text=dr["tcno"].ToString();
				bunifuMaterialTextbox6.Text=dr["odanosu"].ToString();
				dateTimePicker1.Value=Convert.ToDateTime(dr["giristarih"].ToString());
				dateTimePicker2.Value=Convert.ToDateTime(dr["cikistarih"].ToString());
			}
			con.Close();
			
		}
		
		void AktifmusteriLoad(object sender, EventArgs e)
		{
			bunifuiOSSwitch1.Value=true;
			
		}
		
		void BunifuiOSSwitch1OnValueChange(object sender, EventArgs e)
		{
			bunifuiOSSwitch2.Value=false;
			bunifuiOSSwitch3.Value=false;
			bunifuiOSSwitch4.Value=false;
			bunifuiOSSwitch5.Value=false;
			if(bunifuiOSSwitch1.Value==true){
				label1.Text="Aktif";
				baglanti1="Select * from musteri where durum='Aktif'";
			}else if(bunifuiOSSwitch1.Value==false){
				label1.Text="Pasif";
				baglanti1="Select * from musteri where durum='Pasif'";
			}
			
		}
		
		void BunifuiOSSwitch2OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch2.Value==true){
				bunifuiOSSwitch3.Value=false;
				bunifuiOSSwitch4.Value=false;
				bunifuiOSSwitch5.Value=false;
				baglanti2=baglanti1.ToString()+" and adi='";
				bunifuMaterialTextbox1.Text="İsme Göre";
			}
		}
		
		void BunifuiOSSwitch3OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch3.Value==true){
				bunifuiOSSwitch2.Value=false;
				bunifuiOSSwitch4.Value=false;
				bunifuiOSSwitch5.Value=false;
				baglanti2=baglanti1.ToString()+" and soyadi='";
				bunifuMaterialTextbox1.Text="Soyisme Göre";
			}
		}
		
		void BunifuiOSSwitch4OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch4.Value==true){
				bunifuiOSSwitch3.Value=false;
				bunifuiOSSwitch2.Value=false;
				bunifuiOSSwitch5.Value=false;
				baglanti2=baglanti1.ToString()+" and tcno='";
				bunifuMaterialTextbox1.Text="Kimlik No";
			}
		}
		
		void BunifuiOSSwitch5OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch5.Value==true){
				bunifuiOSSwitch3.Value=false;
				bunifuiOSSwitch4.Value=false;
				bunifuiOSSwitch2.Value=false;
				baglanti2=baglanti1.ToString()+" and telefon='";
				bunifuMaterialTextbox1.Text="Telefon";
			}
		}
		
		
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			if(label1.Text=="Aktif"){
				baglanti1="Select * from musteri where durum='Aktif'";
			}
			if(label1.Text=="Pasif"){
				baglanti1="Select * from musteri where durum='Pasif'";
			}
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand(baglanti2.ToString()+bunifuMaterialTextbox1.Text.ToString()+"'",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			int i=1;
			while(dr.Read()){
				Button btn = new Button();
				btn.Width=200;
				btn.Height=50;
				btn.FlatStyle=FlatStyle.Flat;
				btn.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
				btn.FlatAppearance.BorderSize=0;
				btn.Text=dr["musteriid"].ToString()+"* "+dr["adi"].ToString()+" "+dr["soyadi"].ToString();
				btn.Name="btn_" + (i + 1).ToString();
				btn.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
				btn.ForeColor=Color.White;
				btn.Location=new Point(0,(50*i)-50);
				btn.Click+=musterigoster;
				panel1.Controls.Add(btn);
				i++;
			}
			con.Close();
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void AktifmusteriMouseDown(object sender, MouseEventArgs e)
		{
			
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void AktifmusteriMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void AktifmusteriMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
}

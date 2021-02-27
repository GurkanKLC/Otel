/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 04.06.2020
 * Time: 17:56
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
	/// Description of odaislem.
	/// </summary>
	public partial class odaislem : Form
	{
		private static string cocuk,klima,ask,wifi,teras,vip,odadurum;
		public static string odano="Gelmedi";
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public odaislem()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void OdaislemLoad(object sender, EventArgs e)
		{
			odagetir();
		}
		public void isaretleme(string odano){
			
			monthCalendar1.RemoveAllBoldedDates();
			DateTime giris=DateTime.Today;
			DateTime cikis=DateTime.Today;
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select  * from musteri  where  odanosu=@odano",con);
			cmd.Parameters.AddWithValue("@odanosu",odano);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				giris=Convert.ToDateTime(dr["giristarih"].ToString());
				cikis=Convert.ToDateTime(dr["cikistarih"].ToString());
				while(giris<=cikis){
					if(giris!=null || cikis!=null){
						monthCalendar1.AddBoldedDate(giris);
						giris=giris.AddDays(1);
						
					}
					
				}
				
			}
			con.Close();
			monthCalendar1.UpdateBoldedDates();
		}
		public void odagetir(){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from odalar where odadurum='Müsait' or odadurum='Beklemede'",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			int i=1;
			while(dr.Read()){
				Button btn = new Button();
				btn.Width=120;
				btn.Height=50;
				btn.FlatStyle=FlatStyle.Flat;
				btn.ForeColor=Color.White;
				btn.FlatAppearance.BorderSize=0;
				btn.Text=dr["odano"].ToString();
				btn.Name="btn_" + (i + 1).ToString();
				btn.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
				btn.Location=new Point(0,(50*i)-50);
				btn.Click+=odagoster;
				panel1.Controls.Add(btn);
				i++;
			}
			con.Close();
			
		}
		public void odagoster(object sender,EventArgs e){
			
			Button tiklanan=(sender as Button);
			odano=tiklanan.Text;
			isaretleme(odano);
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from odalar where odano=@odano",con);
			cmd.Parameters.AddWithValue("@odano",tiklanan.Text);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				bunifuMaterialTextbox1.Text=dr["odakisisayi"].ToString();
				bunifuMaterialTextbox2.Text=dr["odaalan"].ToString();
				bunifuMaterialTextbox3.Text=dr["odaucret"].ToString();
				label11.Text=dr["odano"].ToString();
				if(dr["cocuk"].ToString()=="var"){
					bunifuiOSSwitch1.Value=true;
				}else{
					bunifuiOSSwitch1.Value=false;
				}
				if(dr["klima"].ToString()=="var"){
					bunifuiOSSwitch2.Value=true;
				}else{
					bunifuiOSSwitch2.Value=false;
				}
				if(dr["aşk"].ToString()=="var"){
					bunifuiOSSwitch3.Value=true;
				}else{
					bunifuiOSSwitch3.Value=false;
				}
				if(dr["wifi"].ToString()=="var"){
					bunifuiOSSwitch4.Value=true;
				}else{
					bunifuiOSSwitch4.Value=false;
				}
				if(dr["teras"].ToString()=="var"){
					bunifuiOSSwitch5.Value=true;
				}else{
					bunifuiOSSwitch5.Value=false;
				}
				if(dr["vip"].ToString()=="var"){
					bunifuiOSSwitch6.Value=true;
				}else{
					bunifuiOSSwitch6.Value=false;
				}
				if(dr["odadurum"].ToString()=="Müsait"){
					bunifuiOSSwitch7.Value=true;
				}else{
					bunifuiOSSwitch7.Value=false;
				}
			}
		}
		
		void BunifuiOSSwitch1OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch1.Value==true){
				cocuk="var";
				label1.Text="Çocuk Yatağı Var";
			}else{
				label1.Text="Çocuk Yatağı Yok";
				cocuk="yok";
			}
		}
		
		void BunifuiOSSwitch2OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch2.Value==true){
				klima="var";
				label2.Text="Klima Var";
			}else{
				label2.Text="Klima Yok";
				klima="yok";
			}
		}
		
		void BunifuiOSSwitch3OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch3.Value==true){
				ask="var";
				label3.Text="Çiftlere Özel";
			}else{
				label3.Text="Genel";
				ask="yok";
			}
		}
		
		void BunifuiOSSwitch4OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch4.Value==true){
				wifi="var";
				label4.Text="Wifi Var";
			}else{
				label4.Text="Wifi Yok";
				wifi="yok";
			}
		}
		
		void BunifuiOSSwitch5OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch5.Value==true){
				teras="var";
				label5.Text="Teras Var";
			}else{
				teras="yok";
				label5.Text="Teras Yok";
			}
		}
		
		void BunifuiOSSwitch6OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch6.Value==true){
				vip="var";
				label6.Text="Vip Ayrıcalık";
			}else{
				vip="yok";
				label6.Text="Standart";
			}
		}
		
		void BunifuiOSSwitch7OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch7.Value==true){
				odadurum="Müsait";
				label8.Text="Müsait";
			}else{
				odadurum="Beklemede";
				label8.Text="Beklemede";
			}
		}
		
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			
			try{
				OleDbConnection bag= new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");bag.Open();
				OleDbCommand commad = new OleDbCommand("update odalar set odaalan=@odaalan,odakisisayi=@odakisisayi,odano=odano,odakatsayi=odakatsayi,odadurum=@odadurum,odaucret=@odaucret,cocuk=@cocuk,kirabastarih=kirabastarih,kirabittarih=kirabittarih,kiragun=kiragun,klima=@klima,aşk=@ask,wifi=@wifi,teras=@teras,vip=@vip where odano='"+odano.ToString()+"' ", bag);
				commad.Parameters.AddWithValue("@odaalan",bunifuMaterialTextbox2.Text);
				commad.Parameters.AddWithValue("@odakisisayi",bunifuMaterialTextbox1.Text);
				commad.Parameters.AddWithValue("@odadurum",odadurum.ToString());
				commad.Parameters.AddWithValue("@odaucret",bunifuMaterialTextbox3.Text);
				commad.Parameters.AddWithValue("@cocuk",cocuk.ToString());
				commad.Parameters.AddWithValue("@klima",klima.ToString());
				commad.Parameters.AddWithValue("@ask",ask.ToString());
				commad.Parameters.AddWithValue("@wifi",wifi.ToString());
				commad.Parameters.AddWithValue("@teras",teras.ToString());
				commad.Parameters.AddWithValue("@vip",vip.ToString());
				commad.ExecuteNonQuery();
				bag.Close();
				MessageBox.Show("Oda Güncellendi");
			}catch{
				MessageBox.Show("Hata");
			}
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void OdaislemMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void OdaislemMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void OdaislemMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
}

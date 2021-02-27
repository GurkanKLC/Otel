/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 03.06.2020
 * Time: 12:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
namespace Otel
{
	/// <summary>
	/// Description of musterikayit.
	/// </summary>
	public partial class musterikayit : Form
	{
		private static string cocuk="yok";
		private static string klima="yok";
		private static string ask="yok";
		private static string wifi="yok";
		private static string teras="yok";
		private static string vip="yok";
		private static int kisisayi=1;
		private static int tarihler=0;
		private static int tarihcakisma1=0;
		private static DateTime giris;
		private static DateTime cikis;
		public static string odano="gelmedi";
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public musterikayit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void odabilgileri(string odano){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from odalar where odano=@odano",con);
			cmd.Parameters.AddWithValue("@odano",odano);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read())
			{
				comboBox1.Items.Add(dr["odano"].ToString());
				label39.Text=dr["odano"].ToString();
				label41.Text=dr["odaalan"].ToString()+"m^2";
				label45.Text=dr["odakisisayi"].ToString();
				label43.Text=dr["odaucret"].ToString()+"TL";
			}
			con.Close();
		}
		public void odagetir(){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from odalar where odakisisayi>=@kisisayi and cocuk=@cocuk and klima=@klima and aşk=@ask and wifi=@wifi and teras=@teras and vip=@vip order by odano",con);
			cmd.Parameters.AddWithValue("@kisisayi",kisisayi);
			cmd.Parameters.AddWithValue("@cocuk",cocuk.ToString());
			cmd.Parameters.AddWithValue("@klima",klima.ToString());
			cmd.Parameters.AddWithValue("@ask",ask.ToString());
			cmd.Parameters.AddWithValue("@wifi",wifi.ToString());
			cmd.Parameters.AddWithValue("@teras",teras.ToString());
			cmd.Parameters.AddWithValue("@vip",vip.ToString());
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read())
			{
				comboBox1.Items.Add(dr["odano"].ToString());
				label39.Text=dr["odano"].ToString();
				label41.Text=dr["odaalan"].ToString()+"m^2";
				label45.Text=dr["odakisisayi"].ToString();
				label43.Text=dr["odaucret"].ToString()+"TL";
			}
			con.Close();
		}

		
		void BunifuiOSSwitch2OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch2.Value==true){
				cocuk="var";
			}else{
				cocuk="yok";
			}
		}
		
		void BunifuiOSSwitch3OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch3.Value==true){
				klima="var";
			}else{
				klima="yok";
			}
		}
		
		void BunifuiOSSwitch4OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch4.Value==true){
				ask="var";
			}else{
				ask="yok";
			}
		}
		
		void BunifuiOSSwitch5OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch5.Value==true){
				wifi="var";
			}else{
				wifi="yok";
			}
		}
		
		void BunifuiOSSwitch6OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch6.Value==true){
				teras="var";
			}else{
				teras="yok";
			}
		}
		
		void BunifuiOSSwitch7OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch7.Value==true){
				vip="var";
			}else{
				vip="yok";
			}
		}
		void ComboBox1DropDown(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();
			odagetir();
		}
		
		void BunifuiOSSwitch1OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch1.Value==true){
				label8.Text="Erkek";
			}else if(bunifuiOSSwitch1.Value==false){
				label8.Text="Kadın";
			}
			
		}
		
		public void isaretleme(string odano){
		
			monthCalendar1.RemoveAllBoldedDates();
			DateTime giris=DateTime.Today;
			DateTime cikis=DateTime.Today;
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select  * from musteri  where  odanosu=@odano AND durum='Randevu'",con);
			cmd.Parameters.AddWithValue("@odanosu",odano);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				giris=Convert.ToDateTime(dr["giristarih"].ToString());
				cikis=Convert.ToDateTime(dr["cikistarih"].ToString());
				while(giris<=cikis){
					if(giris!=null || cikis!=null){
						monthCalendar1.AddBoldedDate(giris);
						giris=giris.AddDays(1);
						tarihler++;
					}
					
				}
				
			}
			con.Close();
			DateTime girisa=DateTime.Today;
			DateTime cikisa=DateTime.Today;
			OleDbConnection cona = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); cona.Open();
			OleDbCommand cmda = new OleDbCommand("Select  * from musteri  where  odanosu=@odano AND durum='Aktif'",cona);
			cmda.Parameters.AddWithValue("@odanosu",odano);
			OleDbDataReader dra = cmda.ExecuteReader();
			while(dra.Read()){
				girisa=Convert.ToDateTime(dra["giristarih"].ToString());
				cikisa=Convert.ToDateTime(dra["cikistarih"].ToString());
				while(girisa<=cikisa){
					if(girisa!=null || cikisa!=null){
						monthCalendar1.AddBoldedDate(girisa);
						girisa=girisa.AddDays(1);
						tarihler++;
					}
					
				}
				
			}
			cona.Close();
			monthCalendar1.UpdateBoldedDates();
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox1.SelectedIndex>-1){
				monthCalendar1.SelectionStart=DateTime.Today;
				monthCalendar1.SelectionEnd=DateTime.Today.AddDays(1);
				giris=monthCalendar1.SelectionStart;
				cikis=monthCalendar1.SelectionEnd;
				odabilgileri(comboBox1.SelectedItem.ToString());
				isaretleme(comboBox1.SelectedItem.ToString());
		
			}else{
				MessageBox.Show("Lütfen Oda Seçin");
			}
			
			DateTime tarih=DateTime.Today;
		}
		public void tarihcakismakontrol(string odano){
			DateTime[] zamanlar=new DateTime[tarihler];
		
			int i=0;
			DateTime giris2=DateTime.Today;
			DateTime cikis2=DateTime.Today;
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); conn.Open();
			OleDbCommand cmdd = new OleDbCommand("Select  * from musteri  where  odanosu=@odano AND durum='Aktif'",conn);
			cmdd.Parameters.AddWithValue("@odanosu",odano);
			OleDbDataReader drr = cmdd.ExecuteReader();
			while(drr.Read()){
				giris2=Convert.ToDateTime(drr["giristarih"].ToString());
				cikis2=Convert.ToDateTime(drr["cikistarih"].ToString());
				while(giris2<=cikis2){
					if(giris2!=null || cikis2!=null){
						zamanlar[i]=giris2;
						giris2=giris2.AddDays(1);
						i++;
						
					}
				}
				
			}
			DateTime giris2a=DateTime.Today;
			DateTime cikis2a=DateTime.Today;
			OleDbConnection conna = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); conna.Open();
			OleDbCommand cmdda = new OleDbCommand("Select  * from musteri  where  odanosu=@odano AND durum='Randevu'",conna);
			cmdda.Parameters.AddWithValue("@odanosu",odano);
			OleDbDataReader drra = cmdda.ExecuteReader();
			while(drra.Read()){
				giris2a=Convert.ToDateTime(drra["giristarih"].ToString());
				cikis2a=Convert.ToDateTime(drra["cikistarih"].ToString());
				while(giris2a<=cikis2a){
					if(giris2a!=null || cikis2a!=null){
						zamanlar[i]=giris2a;
						giris2a=giris2a.AddDays(1);
						i++;
						
					}
				}
				
			}
			conna.Close();
			DateTime kontrolbasla=monthCalendar1.SelectionStart;
			DateTime kontrolbitir=monthCalendar1.SelectionEnd;
			while(kontrolbasla<=kontrolbitir){
				for(int m=0;m<zamanlar.Length;m++){
					if(zamanlar[m]==kontrolbasla){
					tarihcakisma1=1;
					}
				}
				kontrolbasla=kontrolbasla.AddDays(1);
			}
			tarihler=0;
		}
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			TimeSpan gunsayi=cikis-giris;
			odano=label39.Text;
			if(comboBox1.SelectedIndex>-1){
					tarihcakismakontrol(comboBox1.SelectedItem.ToString());
					
			}else{
				MessageBox.Show("Lütfen Oda Seçin");
			}
		
			
			if(tarihcakisma1==0){
				try{
					if(label15.Text=="Aktif"){
						OleDbConnection bag= new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");bag.Open();
						OleDbCommand commad = new OleDbCommand("update odalar set odaalan=odaalan,odakisisayi=odakisisayi,odano=odano,odakatsayi=odakatsayi,odadurum=@odadurum,odaucret=odaucret,cocuk=cocuk,kirabastarih=@kirabastarih,kirabittarih=@kirabittarih,kiragun=@kiragun where odano='"+odano.ToString()+"' ", bag);
						commad.Parameters.AddWithValue("@odadurum","Dolu");
						commad.Parameters.AddWithValue("@kirabastarih",giris.ToShortDateString());
						commad.Parameters.AddWithValue("@kirabittarih",cikis.ToShortDateString());
						commad.Parameters.AddWithValue("@kiragun",gunsayi.Days.ToString());
						commad.ExecuteNonQuery();
						bag.Close();
					}
					if(numericUpDown1.Value==1  || numericUpDown1.Value==2 || numericUpDown1.Value==3 || numericUpDown1.Value==4){
						OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");
						OleDbCommand cmd = new OleDbCommand();
						con.Open();
						cmd.Connection = con;
						cmd.CommandText = "insert into musteri(adi,soyadi,tcno,telefon,dogtarih,odanosu,musterino,cinsiyet,durum,giristarih,cikistarih) values (@adi,@soyadi,@tcno,@telefon,@dogtarih,@odanosu,@musterino,@cinsiyet,@durum,@giristarih,@cikistarih)";
						cmd.Parameters.AddWithValue("@adi",bunifuMaterialTextbox1.Text);
						cmd.Parameters.AddWithValue("@soyadi",bunifuMaterialTextbox2.Text);
						cmd.Parameters.AddWithValue("@tcno",bunifuMaterialTextbox4.Text);
						cmd.Parameters.AddWithValue("@telefon",bunifuMaterialTextbox3.Text);
						cmd.Parameters.AddWithValue("@dogtarih",bunifuDatepicker1.Value.ToShortDateString());
						cmd.Parameters.AddWithValue("@odanosu",comboBox1.SelectedItem.ToString());
						cmd.Parameters.AddWithValue("@musterino",1);
						cmd.Parameters.AddWithValue("@cinsiyet",label8.Text);
						cmd.Parameters.AddWithValue("@durum",label15.Text);
						cmd.Parameters.AddWithValue("@giristarih",giris.ToShortDateString());
						cmd.Parameters.AddWithValue("@cikistarih",cikis.ToShortDateString());
						cmd.ExecuteNonQuery();
						con.Close();
					}
					if(numericUpDown1.Value==2  || numericUpDown1.Value==3  || numericUpDown1.Value==4){
						OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");
						OleDbCommand cmd = new OleDbCommand();
						con.Open();
						cmd.Connection = con;
						cmd.CommandText = "insert into musteri(adi,soyadi,tcno,telefon,dogtarih,odanosu,musterino,cinsiyet,durum,giristarih,cikistarih) values (@adi,@soyadi,@tcno,@telefon,@dogtarih,@odanosu,@musterino,@cinsiyet,@durum,@giristarih,@cikistarih)";
						cmd.Parameters.AddWithValue("@adi",bunifuMaterialTextbox6.Text);
						cmd.Parameters.AddWithValue("@soyadi",bunifuMaterialTextbox7.Text);
						cmd.Parameters.AddWithValue("@tcno",bunifuMaterialTextbox8.Text);
						cmd.Parameters.AddWithValue("@telefon",bunifuMaterialTextbox5.Text);
						cmd.Parameters.AddWithValue("@dogtarih",bunifuDatepicker2.Value.ToShortDateString());
						cmd.Parameters.AddWithValue("@odanosu",comboBox1.SelectedItem.ToString());
						cmd.Parameters.AddWithValue("@musterino",2);
						cmd.Parameters.AddWithValue("@cinsiyet",label18.Text);
						cmd.Parameters.AddWithValue("@durum",label15.Text);
						cmd.Parameters.AddWithValue("@giristarih",giris.ToShortDateString());
						cmd.Parameters.AddWithValue("@cikistarih",cikis.ToShortDateString());
						cmd.ExecuteNonQuery();
						con.Close();
					}
					if(numericUpDown1.Value==3  || numericUpDown1.Value==4 ){
						OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");
						OleDbCommand cmd = new OleDbCommand();
						con.Open();
						cmd.Connection = con;
						cmd.CommandText = "insert into musteri(adi,soyadi,tcno,telefon,dogtarih,odanosu,musterino,cinsiyet,durum,giristarih,cikistarih) values (@adi,@soyadi,@tcno,@telefon,@dogtarih,@odanosu,@musterino,@cinsiyet,@durum,@giristarih,@cikistarih)";
						cmd.Parameters.AddWithValue("@adi",bunifuMaterialTextbox10.Text);
						cmd.Parameters.AddWithValue("@soyadi",bunifuMaterialTextbox11.Text);
						cmd.Parameters.AddWithValue("@tcno",bunifuMaterialTextbox12.Text);
						cmd.Parameters.AddWithValue("@telefon",bunifuMaterialTextbox9.Text);
						cmd.Parameters.AddWithValue("@dogtarih",bunifuDatepicker3.Value.ToShortDateString());
						cmd.Parameters.AddWithValue("@odanosu",comboBox1.SelectedItem.ToString());
						cmd.Parameters.AddWithValue("@musterino",3);
						cmd.Parameters.AddWithValue("@cinsiyet",label22.Text);
						cmd.Parameters.AddWithValue("@durum",label15.Text);
						cmd.Parameters.AddWithValue("@giristarih",giris.ToShortDateString());
						cmd.Parameters.AddWithValue("@cikistarih",cikis.ToShortDateString());
						cmd.ExecuteNonQuery();
						con.Close();
					}
					if(numericUpDown1.Value==4){
						OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");
						OleDbCommand cmd = new OleDbCommand();
						con.Open();
						cmd.Connection = con;
						cmd.CommandText = "insert into musteri(adi,soyadi,tcno,telefon,dogtarih,odanosu,musterino,cinsiyet,durum,giristarih,cikistarih) values (@adi,@soyadi,@tcno,@telefon,@dogtarih,@odanosu,@musterino,@cinsiyet,@durum,@giristarih,@cikistarih)";
						cmd.Parameters.AddWithValue("@adi",bunifuMaterialTextbox14.Text);
						cmd.Parameters.AddWithValue("@soyadi",bunifuMaterialTextbox15.Text);
						cmd.Parameters.AddWithValue("@tcno",bunifuMaterialTextbox16.Text);
						cmd.Parameters.AddWithValue("@telefon",bunifuMaterialTextbox13.Text);
						cmd.Parameters.AddWithValue("@dogtarih",bunifuDatepicker4.Value.ToShortDateString());
						cmd.Parameters.AddWithValue("@odanosu",comboBox1.SelectedItem.ToString());
						cmd.Parameters.AddWithValue("@musterino",4);
						cmd.Parameters.AddWithValue("@cinsiyet",label26.Text);
						cmd.Parameters.AddWithValue("@durum",label15.Text);
						cmd.Parameters.AddWithValue("@giristarih",giris.ToShortDateString());
						cmd.Parameters.AddWithValue("@cikistarih",cikis.ToShortDateString());
						cmd.ExecuteNonQuery();
						con.Close();
					}
					MessageBox.Show("Kayıt Tamamlandı");
				}
				catch{
					MessageBox.Show("Kayıt Başarısız");
				}
			}else{
				if(comboBox1.SelectedIndex>-1){
					isaretleme(comboBox1.SelectedItem.ToString());
				}else{
					MessageBox.Show("Lütfen Oda Seçin");
				}
				
				MessageBox.Show("Çakışan Tarihler Var Lütfen Düzeltin");
				tarihcakisma1=0;
			}
			if(comboBox1.SelectedIndex>-1){
				isaretleme(comboBox1.SelectedItem.ToString());
			}else{
				MessageBox.Show("Lütfen Oda Seçin");
			}

		}
		
		void BunifuiOSSwitch8OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch8.Value==false){
				label15.Text="Aktif";
			}else if(bunifuiOSSwitch8.Value==true){
				label15.Text="Randevu";
			}
		}
		
		void MusterikayitLoad(object sender, EventArgs e)
		{
			kartkapatma();
			monthCalendar1.MinDate=DateTime.Today;
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			kisisayi=Convert.ToInt16(numericUpDown1.Value);
			kartkapatma();
		}

		public void kartkapatma(){
			
			if(numericUpDown1.Value<=3){
				bunifuCards4.Visible=false;
				bunifuCards4.Enabled=false;
			}else{
				bunifuCards4.Visible=true;
				bunifuCards4.Enabled=true;
			}
			if(numericUpDown1.Value<=2){
				bunifuCards3.Visible=false;
				bunifuCards3.Enabled=false;
			}else{
				bunifuCards3.Visible=true;
				bunifuCards3.Enabled=true;
			}
			if(numericUpDown1.Value<=1){
				bunifuCards2.Visible=false;
				bunifuCards2.Enabled=false;
			}else{
				bunifuCards2.Visible=true;
				bunifuCards2.Enabled=true;
			}
		}
		void Label4Click(object sender, EventArgs e)
		{
			if(bunifuCards1.Height<=47){
				bunifuCards1.Height=406;
				bunifuCards2.Location=new Point(-150,-150);
				bunifuCards3.Location=new Point(-150,-150);
				bunifuCards4.Location=new Point(-150,-150);
			}else if(bunifuCards1.Height>47){
				bunifuCards1.Height=47;
				bunifuCards2.Location=new Point(5,95);
				bunifuCards3.Location=new Point(5,148);
				bunifuCards4.Location=new Point(5,200);
			}
			kartkapatma();
		}
		
		void Label20Click(object sender, EventArgs e)
		{
			if(bunifuCards2.Height<=47){
				bunifuCards2.Height=406;
				bunifuCards2.Location=new Point(5,41);
				bunifuCards1.Location=new Point(-150,-150);
				bunifuCards3.Location=new Point(-150,-150);
				bunifuCards4.Location=new Point(-150,-150);
			}else if(bunifuCards2.Height>47){
				bunifuCards2.Height=47;
				bunifuCards2.Location=new Point(5,95);
				bunifuCards1.Location=new Point(5,41);
				bunifuCards3.Location=new Point(5,148);
				bunifuCards4.Location=new Point(5,200);
			}
		}
		
		void Label24Click(object sender, EventArgs e)
		{
			if(bunifuCards3.Height<=47){
				bunifuCards3.Height=406;
				bunifuCards2.Location=new Point(-150,-150);
				bunifuCards1.Location=new Point(-150,-150);
				bunifuCards3.Location=new Point(5,41);
				bunifuCards4.Location=new Point(-150,-150);
			}else if(bunifuCards3.Height>47){
				bunifuCards3.Height=47;
				bunifuCards2.Location=new Point(5,95);
				bunifuCards1.Location=new Point(5,41);
				bunifuCards3.Location=new Point(5,148);
				bunifuCards4.Location=new Point(5,200);
			}
		}
		
		void Label28Click(object sender, EventArgs e)
		{
			if(bunifuCards4.Height<=47){
				bunifuCards4.Height=406;
				bunifuCards2.Location=new Point(-150,-150);
				bunifuCards1.Location=new Point(-150,-150);
				bunifuCards3.Location=new Point(-150,-150);
				bunifuCards4.Location=new Point(5,41);
			}else if(bunifuCards4.Height>47){
				bunifuCards4.Height=47;
				bunifuCards2.Location=new Point(5,95);
				bunifuCards1.Location=new Point(5,41);
				bunifuCards3.Location=new Point(5,148);
				bunifuCards4.Location=new Point(5,200);
			}
		}
		
		
		void MonthCalendar1DateSelected(object sender, DateRangeEventArgs e)
		{
			giris=monthCalendar1.SelectionStart;
			cikis=monthCalendar1.SelectionEnd;
			
		}
		
		void MonthCalendar1MouseUp(object sender, MouseEventArgs e)
		{
			giris=monthCalendar1.SelectionStart;
			cikis=monthCalendar1.SelectionEnd;
			tarihcakisma1=0;
		}
		
		void BunifuiOSSwitch9OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch9.Value==true){
				label18.Text="Erkek";
			}else if(bunifuiOSSwitch9.Value==false){
				label18.Text="Kadın";
			}
		}
		
		void BunifuiOSSwitch10OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch10.Value==true){
				label22.Text="Erkek";
			}else if(bunifuiOSSwitch10.Value==false){
				label22.Text="Kadın";
			}
		}
		
		void BunifuiOSSwitch11OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch11.Value==true){
				label26.Text="Erkek";
			}else if(bunifuiOSSwitch11.Value==false){
				label26.Text="Kadın";
			}
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		
		void MusterikayitMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
    dragCursorPoint = Cursor.Position;
    dragFormPoint = this.Location;
		}
		
		void MusterikayitMouseMove(object sender, MouseEventArgs e)
		{
			 if (dragging)
    {
        Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
        this.Location = Point.Add(dragFormPoint, new Size(dif));
    }
		}
		
		void MusterikayitMouseUp(object sender, MouseEventArgs e)
		{
			  dragging = false;	
		}
	}
}

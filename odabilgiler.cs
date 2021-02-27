/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 02.06.2020
 * Time: 19:43
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
	/// Description of odabilgiler.
	/// </summary>
	public partial class odabilgiler : Form
	{
		public static string odano="100";
	public static int tarihcakisma1=0;
			public static int tarihler=0;
			private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public odabilgiler()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			 odagetir();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void odagetir(){
			
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from odalar where  odano='"+odano.ToString()+"'",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				dateTimePicker1.Value=Convert.ToDateTime(dr["kirabastarih"].ToString());
				dateTimePicker2.Value=Convert.ToDateTime(dr["kirabittarih"].ToString());
				TimeSpan gunsayi=dateTimePicker2.Value-dateTimePicker1.Value;
				label6.Text=gunsayi.Days.ToString();
				label5.Text=dr["odakisisayi"].ToString();
				label3.Text=odano.ToString();
			
			}
			con.Close();
		}
		void BunifuiOSSwitch1OnValueChange(object sender, EventArgs e)
		{
			
			}
			public void tarihcakismakontrol(string odano){
			DateTime[] zamanlar=new DateTime[30];
			int i=0;
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
	//
			DateTime kontrolbasla=dateTimePicker1.Value;
			DateTime kontrolbitir=dateTimePicker2.Value;
			while(kontrolbasla<=kontrolbitir){
				for(int m=0;m<zamanlar.Length;m++){
					if(zamanlar[m]==kontrolbasla){
					tarihcakisma1=1;
					}
				}
				kontrolbasla=kontrolbasla.AddDays(1);
			}
	
		}
		public int tarihkontrol(DateTime giristarih,DateTime cikistarih){
			int kontrol=1;
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from musteri where  odanosu='"+odano.ToString()+"' and durum='Randevu'  ",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				if(Convert.ToDateTime(dr["giristarih"].ToString())<cikistarih){
					kontrol=0;
				}else{
				kontrol=1;
			}
			}
			
			con.Close();
			return kontrol;
		}
		void BunifuiOSSwitch1Click(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch1.Value==true){
				bunifuiOSSwitch1.Value=true;
				dateTimePicker2.Enabled=true;
				dateTimePicker1.Enabled=true;
				
			}else{
				tarihcakismakontrol(odano);
				if(tarihcakisma1==0){
						bunifuiOSSwitch1.Value=false;
				dateTimePicker2.Enabled=false;
				dateTimePicker1.Enabled=false;
				OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
				string kayit = "update odalar set kirabastarih=@kirabastarih,kirabittarih=@kirabittarih where odano='"+odano.ToString()+"'";
				// müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
				OleDbCommand komut = new OleDbCommand(kayit, con);
				//Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
				komut.Parameters.AddWithValue("@kirabastarih",dateTimePicker1.Value.ToShortDateString());
				komut.Parameters.AddWithValue("@kirabittarih",dateTimePicker2.Value.ToShortDateString());
				//Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
				komut.ExecuteNonQuery();
				//Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
				con.Close();
				MessageBox.Show("Tarihler Güncellendi.");
				OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); conn.Open();
				// müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
				OleDbCommand komutt = new OleDbCommand("update musteri set adi=adi,soyadi=soyadi,tcno=tcno,telefon=telefon,dogtarih=dogtarih,odanosu=odanosu,musterino=musterino,cinsiyet=cinsiyet,durum=durum,giristarih=@giristarih,cikistarih=@cikistarih where odanosu='"+odano.ToString()+"' and durum='Aktif'", conn);
			
				komutt.Parameters.AddWithValue("@giristarih",dateTimePicker1.Value.ToShortDateString());
					komutt.Parameters.AddWithValue("@cikistarih",dateTimePicker2.Value.ToShortDateString());
				//Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
				komutt.ExecuteNonQuery();
				//Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
				conn.Close();
				MessageBox.Show("Güncellendi");
				odagetir();
				tarihcakisma1=0;
				}else{
					MessageBox.Show("Bu Tarihler Arasında Oda Kiralanmıştır");
					tarihcakisma1=0;
				}
				}
			
		}
		
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			try{
				dateTimePicker2.MinDate= new DateTime(dateTimePicker1.Value.Year,dateTimePicker1.Value.Month,dateTimePicker1.Value.Day);
			}catch{
				MessageBox.Show("HATA");
			}
		}
		
		void DateTimePicker2ValueChanged(object sender, EventArgs e)
		{
			try{
				dateTimePicker1.MaxDate= new DateTime(dateTimePicker2.Value.Year,dateTimePicker2.Value.Month,dateTimePicker2.Value.Day);
			}catch{
				MessageBox.Show("HATA");
			}
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void OdabilgilerMouseDown(object sender, MouseEventArgs e)
		{
			
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void OdabilgilerMouseMove(object sender, MouseEventArgs e)
		{
			
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void OdabilgilerMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
	
	}


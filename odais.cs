/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 05.04.2020
 * Time: 00:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Timers;
namespace Otel
{
	/// <summary>
	/// Description of odais.
	/// </summary>
	public partial class odais : Form
	{
		int kntrl=0;
		public static string odano="Gelmedi";
		public odais()
		{
			
			InitializeComponent();
			formislemleri();
			musterigetir();
			odagetir();
			this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		}
		public void formislemleri(){
			this.Width=600;
			this.Height=620;
		}
		public void musterigetir(){
			mkart1.Visible=false;
			mkart2.Visible=false;
			mkart3.Visible=false;
			mkart4.Visible=false;
			int odakisisayi=0;
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			
			OleDbCommand cmd = new OleDbCommand("Select * from musteri where  odanosu='"+odano.ToString()+"'",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				
				if(dr["musterino"].ToString()==Convert.ToString(1)){
					
					mkart1.Visible=true;
										dateTimePicker4.Value=Convert.ToDateTime(dr["dogtarih"].ToString());
					odakisisayi++;
					if(dr["cinsiyet"].ToString()=="erkek"){
						mkart1.color=Color.AliceBlue;
					}else{
						mkart1.color=Color.Pink;
					}
					
				}
				
				if(dr["musterino"].ToString()==Convert.ToString(2)){
					mkart2.Visible=true;
					
					dateTimePicker3.Value=Convert.ToDateTime(dr["dogtarih"].ToString());
					odakisisayi++;
					if(dr["cinsiyet"].ToString()=="erkek"){
						mkart2.color=Color.AliceBlue;
					}else{
						mkart2.color=Color.Pink;
					}
				}
				
				if(dr["musterino"].ToString()==Convert.ToString(3)){
					mkart3.Visible=true;
					
					dateTimePicker5.Value=Convert.ToDateTime(dr["dogtarih"].ToString());
					odakisisayi++;
					if(dr["cinsiyet"].ToString()=="erkek"){
						mkart3.color=Color.AliceBlue;
					}else{
						mkart3.color=Color.Pink;
					}
					
				}
				
				if(dr["musterino"].ToString()==Convert.ToString(4)){
					mkart4.Visible=true;
					
					dateTimePicker6.Value=Convert.ToDateTime(dr["dogtarih"].ToString());
					odakisisayi++;
					if(dr["cinsiyet"].ToString()=="erkek"){
						mkart4.color=Color.AliceBlue;
					}else{
						mkart4.color=Color.Pink;
					}
				}
				
			}
			
			
			con.Close();
			label5.Text=odakisisayi.ToString();
		}
		public int  yashesapla(string tarih) {
			int yas;
			DateTime dogumtarihi;
			dogumtarihi = Convert.ToDateTime(tarih);
			yas = DateTime.Now.Year - dogumtarihi.Year;

			return yas;
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
				odakisisayilbl.Text=dr["odakisisayi"].ToString();
				odaalanlbl.Text=dr["odaalan"].ToString();
				odaucretlbl.Text=dr["odaucret"].ToString();
				label3.Text=odano.ToString();
				if(dr["cocuk"].ToString()=="var"){
					
					pictureBox1.BackgroundImage=Image.FromFile("confirm.png");
				}else{
					pictureBox1.BackgroundImage=Image.FromFile("cancel.png");
				}
			}
			con.Close();
		}
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			
			if(kntrl==0){
				bunifuFlatButton1.Text="Kaydet";
			
				this.Refresh();
				kntrl=1;
				this.Width=732;
				bunifuCards2.Visible=true;
			}else{
				bunifuFlatButton1.Text="Düzenle";
			
				kntrl=0;
				this.Width=600;
				bunifuCards2.Visible=false;
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
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			
			siparis.odano=odano;
			siparis sip =  new siparis();
			sip.Show();
			
		}
		

		
//		void BunifuSwitch5Click(object sender, EventArgs e)
//		{
//			if(bunifuSwitch5.Value==true){
//				bunifuSwitch5.Value=true;
//				dateTimePicker2.Enabled=true;
//				dateTimePicker1.Enabled=true;
//				
//			}else{
//				bunifuSwitch5.Value=false;
//				dateTimePicker2.Enabled=false;
//				dateTimePicker1.Enabled=false;
//				OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
//				string kayit = "update odalar set kirabastarih=@kirabastarih,kirabittarih=@kirabittarih where odano='"+odano.ToString()+"'";
//				// müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
//				OleDbCommand komut = new OleDbCommand(kayit, con);
//				//Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
//				komut.Parameters.AddWithValue("@kirabastarih",dateTimePicker1.Value.ToShortDateString());
//				komut.Parameters.AddWithValue("@kirabittarih",dateTimePicker2.Value.ToShortDateString());
//				//Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
//				komut.ExecuteNonQuery();
//				//Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
//				con.Close();
//				odagetir();
//				MessageBox.Show("Tarihler Güncellendi.");
//				
//			}
//		}

	
	}
}

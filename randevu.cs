/*
 * Created by SharpDevelop.
 * User: Gürses
 * Date: 04.06.2020
 * Time: 15:34
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
	/// Description of randevu.
	/// </summary>
	public partial class randevu : Form
	{
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public randevu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RandevuLoad(object sender, EventArgs e)
		{
		}
		
		void BunifuiOSSwitch1OnValueChange(object sender, EventArgs e)
		{
			if(bunifuiOSSwitch1.Value==true){
				label1.Text="İsme Göre";
				bunifuMaterialTextbox1.Text="İsim Giriniz";
			}else if(bunifuiOSSwitch1.Value==false){
				label1.Text="Soyisme Göre";
				bunifuMaterialTextbox1.Text="Soyisim Giriniz";
			}
		}
		
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex>-1){
				string secilen=listBox1.SelectedItem.ToString();
				char[] ayrac = { '*',};
				string[] parcalar = secilen.Split(ayrac);
				
				OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
				
				OleDbCommand cmd = new OleDbCommand("Select * from musteri where musteriid=@musteriid",con);
				cmd.Parameters.AddWithValue("@musteriid",parcalar[0].ToString());
				OleDbDataReader dr = cmd.ExecuteReader();
				while(dr.Read()){
					label12.Text=dr["musteriid"].ToString();
					label11.Text=dr["odanosu"].ToString();
					bunifuMaterialTextbox2.Text=dr["adi"].ToString();
					bunifuMaterialTextbox4.Text=dr["soyadi"].ToString();
					bunifuMaterialTextbox3.Text=dr["telefon"].ToString();
					bunifuMaterialTextbox5.Text=dr["tcno"].ToString();
					label8.Text=dr["cinsiyet"].ToString();
					dateTimePicker3.Value=Convert.ToDateTime(dr["dogtarih"].ToString());
					dateTimePicker4.Value=Convert.ToDateTime(dr["giristarih"].ToString());
					dateTimePicker5.Value=Convert.ToDateTime(dr["cikistarih"].ToString());
					
				}
				if(label8.Text=="Erkek"){
					bunifuiOSSwitch3.Value=false;
				}else{
					bunifuiOSSwitch3.Value=true;
				}
				con.Close();
			}
			
			
		}
		
		void BunifuThinButton22Click(object sender, EventArgs e)
		{
			if(bunifuThinButton22.ButtonText=="Güncelle"){
				bunifuMaterialTextbox2.Enabled=true;
				bunifuMaterialTextbox4.Enabled=true;
				bunifuMaterialTextbox5.Enabled=true;
				bunifuMaterialTextbox3.Enabled=true;
				dateTimePicker3.Enabled=true;
				bunifuiOSSwitch3.Enabled=true;
				bunifuThinButton22.ButtonText="Kaydet";
				
			}else{
				
				try{
					OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
					// müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
					OleDbCommand komut = new OleDbCommand("update musteri set adi=@isim,soyadi=@soyisim,tcno=@tcno,telefon=@telefon,dogtarih=@dogtarih,odanosu=odanosu,musterino=musterino,cinsiyet=@cinsiyet,durum=durum where musteriid=@musteriid", con);
					komut.Parameters.AddWithValue("@isim", bunifuMaterialTextbox2.Text);
					komut.Parameters.AddWithValue("@soyisim", bunifuMaterialTextbox4.Text);
					komut.Parameters.AddWithValue("@tcno", bunifuMaterialTextbox5.Text);
					komut.Parameters.AddWithValue("@telefon", bunifuMaterialTextbox3.Text);
					komut.Parameters.AddWithValue("@dogtarih",dateTimePicker3.Value.ToShortDateString());
					komut.Parameters.AddWithValue("@cinsiyet",label8.Text);
					komut.Parameters.AddWithValue("@musteriid",label12.Text);
					//Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
					komut.ExecuteNonQuery();
					//Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
					con.Close();
					MessageBox.Show("Güncellendi");
				}catch{
					MessageBox.Show("Hata");
				}
				bunifuMaterialTextbox2.Enabled=false;
				bunifuMaterialTextbox4.Enabled=false;
				bunifuMaterialTextbox5.Enabled=false;
				bunifuMaterialTextbox3.Enabled=false;
				dateTimePicker3.Enabled=false;
				bunifuiOSSwitch3.Enabled=false;
				bunifuThinButton22.ButtonText="Güncelle";
				
			}
		}
		
		void BunifuThinButton23Click(object sender, EventArgs e)
		{
			
			
			DialogResult secenek= MessageBox.Show("Rezervasyon İptal Edilsin mi?", "Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			
			if (secenek == DialogResult.Yes)
			{
				
				try{
					OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
					// müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
					OleDbCommand komut = new OleDbCommand("update musteri set adi=adi,soyadi=soyadi,tcno=tcno,telefon=telefon,dogtarih=dogtarih,odanosu=odanosu,musterino=musterino,cinsiyet=cinsiyet,durum='pasif' where musteriid=@musteriid", con);
					komut.Parameters.AddWithValue("@musteriid",label12.Text);
					//Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
					komut.ExecuteNonQuery();
					//Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
					con.Close();
					MessageBox.Show("İptal Edildi");
				}catch{
					MessageBox.Show("Hata");
				}
			}
		}
		
		
		void BunifuThinButton24Click(object sender, EventArgs e)
		{
			string durum="Aktif";
			string odadurumm="Aktif";
			DialogResult secenek= MessageBox.Show("Rezervasyon Aktif Edilsin mi?", "Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			
			if (secenek == DialogResult.Yes)
			{
				try{
					OleDbConnection bag= new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");bag.Open();
					OleDbCommand commad = new OleDbCommand("update odalar set odadurum=@odadurum,kirabastarih=@kirabastarih,kirabittarih=@kirabittarih where odano=@odano", bag);
					commad.Parameters.AddWithValue("@odadurum",odadurumm);
					commad.Parameters.AddWithValue("@kirabastarih",dateTimePicker4.Value.ToShortDateString());
					commad.Parameters.AddWithValue("@kirabittarih",dateTimePicker5.Value.ToShortDateString());
					commad.Parameters.AddWithValue("@odano",Convert.ToInt16(label11.Text));
					commad.ExecuteNonQuery();
					bag.Close();

					OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
					// müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
					OleDbCommand komut = new OleDbCommand("update musteri set adi=adi,soyadi=soyadi,tcno=tcno,telefon=telefon,dogtarih=dogtarih,odanosu=odanosu,musterino=musterino,cinsiyet=cinsiyet,durum=@durum where musteriid=@musteriid", con);
					komut.Parameters.AddWithValue("@durum",durum);
					komut.Parameters.AddWithValue("@musteriid",label12.Text);
					//Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
					komut.ExecuteNonQuery();
					//Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
					con.Close();
					MessageBox.Show("Aktifleştirildi");
				}catch{
					MessageBox.Show("Hata");
				}
			}
		}
		
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			if(bunifuiOSSwitch2.Value==true){
				OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
				
				OleDbCommand cmd = new OleDbCommand("Select * from musteri where durum='Randevu' and giristarih>=@giristarih and cikistarih<=@cikistarih",con);
				cmd.Parameters.AddWithValue("@giristarih",dateTimePicker1.Value.ToShortDateString());
				cmd.Parameters.AddWithValue("@cikistarih",dateTimePicker2.Value.ToShortDateString());
				OleDbDataReader dr = cmd.ExecuteReader();
				while(dr.Read()){
					DateTime giris=Convert.ToDateTime(dr["giristarih"].ToString());
					DateTime cikis=Convert.ToDateTime(dr["cikistarih"].ToString());
					listBox1.Items.Add(dr["musteriid"].ToString()+"* İsim:"+dr["adi"].ToString()+" "+dr["soyadi"].ToString()+" Tarih:"+giris.ToShortDateString()+"-"+cikis.ToShortDateString());
				}
				con.Close();
			}else{
				if(bunifuiOSSwitch1.Value==true){
					OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
					
					OleDbCommand cmd = new OleDbCommand("Select * from musteri where durum='Randevu' and adi=@adi ",con);
					cmd.Parameters.AddWithValue("@adi",bunifuMaterialTextbox1.Text);
					
					OleDbDataReader dr = cmd.ExecuteReader();
					while(dr.Read()){
						DateTime giris=Convert.ToDateTime(dr["giristarih"].ToString());
						DateTime cikis=Convert.ToDateTime(dr["cikistarih"].ToString());
						listBox1.Items.Add(dr["musteriid"].ToString()+"* İsim:"+dr["adi"].ToString()+" "+dr["soyadi"].ToString()+" Tarih:"+giris.ToShortDateString()+"-"+cikis.ToShortDateString());
					}
					con.Close();
				}else{
					OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
					
					OleDbCommand cmd = new OleDbCommand("Select * from musteri where durum='Randevu' and soyadi=@soyadi ",con);
					cmd.Parameters.AddWithValue("@soyadi",bunifuMaterialTextbox1.Text);
					
					OleDbDataReader dr = cmd.ExecuteReader();
					while(dr.Read()){
						DateTime giris=Convert.ToDateTime(dr["giristarih"].ToString());
						DateTime cikis=Convert.ToDateTime(dr["cikistarih"].ToString());
						listBox1.Items.Add(dr["musteriid"].ToString()+"* İsim:"+dr["adi"].ToString()+" "+dr["soyadi"].ToString()+" Tarih:"+giris.ToShortDateString()+"-"+cikis.ToShortDateString());
					}
					con.Close();
				}
			}
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void RandevuMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
    dragCursorPoint = Cursor.Position;
    dragFormPoint = this.Location;
		}
		
		void RandevuMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void RandevuMouseUp(object sender, MouseEventArgs e)
		{
		dragging = false;	
		}
	}
}

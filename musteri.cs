
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Timers;
namespace Otel
{
	/// <summary>
	/// Description of musteri.
	/// </summary>
	public partial class musteri : Form
	{
		public static string odano="Gelmedi";
		public static string cinsiyet;
		public static int musterino=0;
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public musteri()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			musterilistele();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void musterilistele(){
			pictureBox1.Visible=false;
			pictureBox2.Visible=false;
			pictureBox3.Visible=false;
			pictureBox4.Visible=false;
			
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			
			OleDbCommand cmd = new OleDbCommand("Select * from musteri where  odanosu='"+odano.ToString()+"' and durum='Aktif'",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				if(dr["musterino"].ToString()==Convert.ToString(1)){
					pictureBox1.Visible=true;
					label1.Visible=true;
					label1.Text=dr["adi"].ToString()+" "+dr["soyadi"].ToString();
					if(dr["cinsiyet"].ToString()=="Erkek"){
						if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox1.Image=Image.FromFile("img/person.png");
						pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox1.Image=Image.FromFile("img/babyb.png");
						pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
						
					}else if(dr["cinsiyet"].ToString()=="Kadın"){
							if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox1.Image=Image.FromFile("img/woman.png");
						pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox1.Image=Image.FromFile("img/babyg.png");
						pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
					}
				}
				
				if(dr["musterino"].ToString()==Convert.ToString(2)){
					pictureBox2.Visible=true;
					label2.Visible=true;
					label2.Text=dr["adi"].ToString()+" "+dr["soyadi"].ToString();
						if(dr["cinsiyet"].ToString()=="Erkek"){
						if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox2.Image=Image.FromFile("img/person.png");
						pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox2.Image=Image.FromFile("img/babyb.png");
						pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
						
					}else if(dr["cinsiyet"].ToString()=="Kadın"){
							if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox2.Image=Image.FromFile("img/woman.png");
						pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox2.Image=Image.FromFile("img/babyg.png");
						pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
					}
					
				}
				
				if(dr["musterino"].ToString()==Convert.ToString(3)){
					pictureBox3.Visible=true;
					label5.Visible=true;
					label5.Text=dr["adi"].ToString()+" "+dr["soyadi"].ToString();
						if(dr["cinsiyet"].ToString()=="Erkek"){
						if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox3.Image=Image.FromFile("img/person.png");
						pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox3.Image=Image.FromFile("img/babyb.png");
						pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
						
					}else if(dr["cinsiyet"].ToString()=="Kadın"){
							if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox3.Image=Image.FromFile("img/woman.png");
						pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox3.Image=Image.FromFile("img/babyg.png");
						pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
					}
				}
				
				if(dr["musterino"].ToString()==Convert.ToString(4)){
					pictureBox4.Visible=true;
					label6.Visible=true;
					label6.Text=dr["adi"].ToString()+" "+dr["soyadi"].ToString();
						if(dr["cinsiyet"].ToString()=="Erkek"){
						if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox4.Image=Image.FromFile("img/person.png");
						pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox4.Image=Image.FromFile("img/babyb.png");
						pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
						
					}else if(dr["cinsiyet"].ToString()=="Kadın"){
							if(yashesapla(dr["dogtarih"].ToString())>=18){
						pictureBox4.Image=Image.FromFile("img/woman.png");
						pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}else{
							pictureBox4.Image=Image.FromFile("img/babyg.png");
						pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						}
						
					}
				}
				
			}
			
			
			con.Close();
		}
		public void kaydet(){
			
			try{
				OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
				// müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
				OleDbCommand komut = new OleDbCommand("update musteri set adi=@isim,soyadi=@soyisim,tcno=@tcno,telefon=@telefon,dogtarih=@dogtarih,odanosu=@odanosu,musterino=@musterino,cinsiyet=@cinsiyet where odanosu='"+odano.ToString()+"' and musterino=@musterino", con);
				komut.Parameters.AddWithValue("@isim", bunifuMaterialTextbox1.Text);
				komut.Parameters.AddWithValue("@soyisim", bunifuMaterialTextbox5.Text);
				komut.Parameters.AddWithValue("@tcno", bunifuMaterialTextbox3.Text);
				komut.Parameters.AddWithValue("@telefon", bunifuMaterialTextbox2.Text);
				komut.Parameters.AddWithValue("@dogtarih",dateTimePicker4.Value.ToShortDateString());
				komut.Parameters.AddWithValue("@odanosu",odano);
				komut.Parameters.AddWithValue("@musterino",musterino);
					komut.Parameters.AddWithValue("@cinsiyet",cinsiyet);
				komut.Parameters.AddWithValue("@musterino",musterino);
				//Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
				komut.ExecuteNonQuery();
				//Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
				con.Close();
				MessageBox.Show("Güncellendi");
			}catch{
				MessageBox.Show("Hata");
			}
			
		}
		public void duzenle(){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from musteri where  odanosu='"+odano.ToString()+"' and musterino=@musterino ",con);
			cmd.Parameters.AddWithValue("@musterino",musterino);
			OleDbDataReader dr = cmd.ExecuteReader();
			
			while(dr.Read()){
				bunifuMaterialTextbox1.Text=dr["adi"].ToString();
				bunifuMaterialTextbox5.Text=dr["soyadi"].ToString();
				bunifuMaterialTextbox2.Text=dr["telefon"].ToString();
				bunifuMaterialTextbox3.Text=dr["tcno"].ToString();
				bunifuMaterialTextbox4.Text=Convert.ToString(yashesapla(dr["dogtarih"].ToString()));
				dateTimePicker4.Value=Convert.ToDateTime(dr["dogtarih"].ToString());
				cinsiyet=dr["cinsiyet"].ToString();
				if(dr["cinsiyet"].ToString()=="erkek"){
					radioButton1.Checked=true;
				}else{
					radioButton2.Checked=true;
				}
			}
			
		}
		public int  yashesapla(string tarih) {
			int yas;
			DateTime dogumtarihi;
			dogumtarihi = Convert.ToDateTime(tarih);
			yas = DateTime.Now.Year - dogumtarihi.Year;

			return yas;
		}
		

		
		void PictureBox1Click(object sender, EventArgs e)
		{
			musterino=1;
			duzenle();
			if(this.Height==175){
				this.Height=385;
			}else{
				this.Height=175;
			}
		}
		

		
		void PictureBox2Click(object sender, EventArgs e)
		{
			musterino=2;
			duzenle();
			if(this.Height==175){
				this.Height=385;
			}else{
				this.Height=175;
			}
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			musterino=3;
			duzenle();
		if(this.Height==175){
				this.Height=385;
			}else{
				this.Height=175;
			}
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			musterino=4;
			duzenle();
			if(this.Height==175){
				this.Height=385;
			}else{
				this.Height=175;
			}
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton1.Checked==true){
				cinsiyet="erkek";
			}
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton2.Checked==true){
				cinsiyet="kadın";
			}
		}
		

		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			
			if(radioButton1.Enabled==false){
				bunifuMaterialTextbox1.Enabled=true;
			bunifuMaterialTextbox2.Enabled=true;
			bunifuMaterialTextbox3.Enabled=true;
			bunifuMaterialTextbox4.Enabled=true;
			bunifuMaterialTextbox5.Enabled=true;
			radioButton1.Enabled=true;
			radioButton2.Enabled=true;
			dateTimePicker4.Enabled=true;
			}else{
				bunifuMaterialTextbox1.Enabled=false;
			bunifuMaterialTextbox2.Enabled=false;
			bunifuMaterialTextbox3.Enabled=false;
			bunifuMaterialTextbox4.Enabled=false;
			bunifuMaterialTextbox5.Enabled=false;
			radioButton1.Enabled=false;
			radioButton2.Enabled=false;
			dateTimePicker4.Enabled=false;
			kaydet();
			}
		}
		
		void MusteriMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void MusteriMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void MusteriMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
		
		void BunifuTileButton1Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

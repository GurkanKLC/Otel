using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otel
{
	
	public partial class Main : Form
	{
		
		public static string[] ozellikler = new string[9];
		public static int geneltoplam=0;
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public Main()
		{
			InitializeComponent();
			string sorgu;
			int kat=100;
			sorgu="Select * from odalar order by odano";
			getir(sorgu,kat);
			
		}
		public void gizle(){
			
			kart1.Visible=false;
			kart2.Visible=false;
			kart3.Visible=false;
			kart4.Visible=false;
			kart5.Visible=false;
			kart6.Visible=false;
			kart7.Visible=false;
			kart8.Visible=false;
			kart9.Visible=false;
		}
		public void getir(string baglanti,int kat){
			gizle();
			
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand(baglanti.ToString(),con);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read())
			{
				
				if(dr["odano"].ToString()==Convert.ToString(kat)){
					kart1.Visible=true;
					ozellikler[0]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						
						kart1.color=Color.Green;
						kartpic1.BackgroundImage=Image.FromFile("bos.png");
						
					}else{
						kart1.color=Color.Red;
						kartpic1.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl1.Text=dr["odano"].ToString();
					
				}else{
					
				}
				
				if(dr["odano"].ToString()==Convert.ToString(kat+1)){
					kart2.Visible=true;
					ozellikler[1]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart2.color=Color.Green;
						kartpic2.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart2.color=Color.Red;
						kartpic2.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl2.Text=dr["odano"].ToString();
					
				}else{
					
				}
				if(dr["odano"].ToString()==Convert.ToString(kat+2)){
					kart3.Visible=true;
					ozellikler[2]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart3.color=Color.Green;
						kartpic3.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart3.color=Color.Red;
						kartpic3.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl3.Text=dr["odano"].ToString();
					
				}else{
					
				}
				if(dr["odano"].ToString()==Convert.ToString(kat+3)){
					kart4.Visible=true;
					ozellikler[3]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart4.color=Color.Green;
						kartpic4.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart4.color=Color.Red;
						kartpic4.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl4.Text=dr["odano"].ToString();
					
				}else{
					
				}
				if(dr["odano"].ToString()==Convert.ToString(kat+4)){
					kart5.Visible=true;
					ozellikler[4]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart5.color=Color.Green;
						kartpic5.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart5.color=Color.Red;
						kartpic5.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl5.Text=dr["odano"].ToString();
					
				}else{
					
				}
				if(dr["odano"].ToString()==Convert.ToString(kat+5)){
					kart6.Visible=true;
					ozellikler[5]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart6.color=Color.Green;
						kartpic6.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart6.color=Color.Red;
						kartpic6.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl6.Text=dr["odano"].ToString();
					
				}else{
					
				}
				if(dr["odano"].ToString()==Convert.ToString(kat+6)){
					kart7.Visible=true;
					ozellikler[6]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart7.color=Color.Green;
						kartpic7.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart7.color=Color.Red;
						kartpic7.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl7.Text=dr["odano"].ToString();
					
				}else{
					
				}
				if(dr["odano"].ToString()==Convert.ToString(kat+7)){
					kart8.Visible=true;
					ozellikler[7]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart8.color=Color.Green;
						kartpic8.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart8.color=Color.Red;
						kartpic8.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl8.Text=dr["odano"].ToString();
					
				}else{
					
				}
				if(dr["odano"].ToString()==Convert.ToString(kat+8)){
					kart9.Visible=true;
					ozellikler[8]=dr["cocuk"].ToString()+"*"+dr["klima"].ToString()+"*"+dr["aşk"].ToString()+"*"+dr["wifi"].ToString()+"*"+dr["teras"].ToString()+"*"+dr["vip"].ToString();
					if(dr["odadurum"].ToString()=="Müsait"){
						kart9.color=Color.Green;
						kartpic9.BackgroundImage=Image.FromFile("bos.png");
					}else{
						kart9.color=Color.Red;
						kartpic9.BackgroundImage=Image.FromFile("dolu.png");
					}
					kartlbl9.Text=dr["odano"].ToString();
				}else{
					
				}

				
			}
			dr.Close();
			con.Close();
			
		}

		void PictureBox1Click(object sender, EventArgs e)
		{
			
			if(pictureBox1.Location.X>20){
				pictureBox1.Location = new Point ( 20, pictureBox1.Location.Y) ;
				panel1.Size=new Size (50,700);
				panel2.Location= new Point(panel2.Location.X-110,panel2.Location.Y);
			}else if(pictureBox1.Location.X<=20){
				panel1.Size=new Size (200,700);
				pictureBox1.Location = new Point ( pictureBox1.Location.X+150,  pictureBox1.Location.Y) ;
				
				panel2.Location= new Point(panel2.Location.X+110,panel2.Location.Y);
			}
			
			
			
			
			
			
			
			
			
			
			
		}
		
		
		void MainFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		
		void BunifuTileButton1Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=100;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTilButton2Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=200;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTileButton3Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=300;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTileButton4Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=400;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTileButton5Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=500;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTileButton6Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=600;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTileButton7Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=700;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTileButton8Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=800;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		void BunifuTileButton9Click(object sender, EventArgs e)
		{
			string sorgu2;
			int kat=900;
			sorgu2="Select * from odalar order by odano";
			getir(sorgu2,kat);
		}
		
		
		public void yonlerdir(string isim,string kontrol){
			if(kontrol=="Color [Red]"){
				try{
					musteri.odano=isim;
					musteri fr= new musteri();
					fr.Show();
				}catch{
					MessageBox.Show("Oda Kiralanmamış");
				}
			}else{
				MessageBox.Show("Oda Kiralanmamış");
			}
		}
		public void yonlerdirsiparis(string odano,string kontrol){
			if(kontrol=="Color [Red]"){
				try{
					siparis.odano=odano;
					siparis fr= new siparis();
					fr.Show();
				}catch{
					MessageBox.Show("Oda Kiralanmamış");
				}
			}else{
				MessageBox.Show("Oda Kiralanmamış");
			}
		}
		public void odabilgileri(string odanos,string kontrol){
			if(kontrol=="Color [Red]"){
				try{
					odabilgiler.odano=odanos;
					odabilgiler fr= new odabilgiler();
					fr.Show();
				}catch{
					MessageBox.Show("Oda Kiralanmamış");
				}
			}else{
				MessageBox.Show("Oda Kiralanmamış");
			}
		}
		void Kart1Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl1.Text,kart1.color.ToString());
		}
		
		void Kart2Click(object sender, EventArgs e)
		{
			
			odabilgileri(kartlbl2.Text,kart2.color.ToString());
		}
		
		
		void Kart3Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl3.Text,kart3.color.ToString());
		}
		
		void Kart4Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl4.Text,kart4.color.ToString());
		}
		
		void Kart5Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl5.Text,kart5.color.ToString());
		}
		
		void Kart6Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl6.Text,kart6.color.ToString());
		}
		
		void Kart7Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl7.Text,kart7.color.ToString());
		}
		
		void Kart8Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl8.Text,kart8.color.ToString());
		}
		
		void Kart9Click(object sender, EventArgs e)
		{
			odabilgileri(kartlbl9.Text,kart9.color.ToString());
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			try{
				musterikayit fr= new musterikayit();
				fr.Show();
			}catch{
				MessageBox.Show("HATA");
			}
		}
		
		void Kart6Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl6.Text,kart6.color.ToString());
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl1.Text,kart1.color.ToString());
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl2.Text,kart2.color.ToString());
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl3.Text,kart3.color.ToString());
		}
		
		void PictureBox7Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl4.Text,kart4.color.ToString());
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl5.Text,kart5.color.ToString());
		}
		
		void PictureBox10Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl7.Text,kart7.color.ToString());
		}
		
		void PictureBox9Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl8.Text,kart8.color.ToString());
		}
		
		void PictureBox8Click(object sender, EventArgs e)
		{
			yonlerdir(kartlbl9.Text,kart9.color.ToString());
		}
		
		void PictureBox11Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl1.Text,kart1.color.ToString());
		}
		
		void PictureBox12Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl2.Text,kart2.color.ToString());
		}
		
		void PictureBox13Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl3.Text,kart3.color.ToString());
		}
		
		void PictureBox16Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl4.Text,kart4.color.ToString());
		}
		
		void PictureBox15Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl5.Text,kart5.color.ToString());
		}
		
		void PictureBox14Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl6.Text,kart6.color.ToString());
		}
		
		void PictureBox17Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl7.Text,kart7.color.ToString());
		}
		
		void PictureBox18Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl8.Text,kart8.color.ToString());
		}
		
		void PictureBox19Click(object sender, EventArgs e)
		{
			yonlerdirsiparis(kartlbl9.Text,kart9.color.ToString());
		}
		public void siparisucrethesapla(string odano){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from siparis where  siparisoda='"+odano.ToString()+"'",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				geneltoplam+=(Convert.ToInt16(dr["ucret"].ToString()))*(Convert.ToInt16(dr["adet"].ToString()));
				
			}
			con.Close();
		}
		public void odaucrethesapla(string odano){
			DateTime baslangic,bitis;
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
			OleDbCommand cmd = new OleDbCommand("Select * from odalar where  odano='"+odano.ToString()+"'",con);
			OleDbDataReader dr = cmd.ExecuteReader();
			while(dr.Read()){
				baslangic=Convert.ToDateTime(dr["kirabastarih"].ToString());
				bitis=Convert.ToDateTime(dr["kirabittarih"].ToString());
				TimeSpan gunsayi=bitis-baslangic;
				geneltoplam+=Convert.ToInt16(dr["odaucret"].ToString())*Convert.ToInt16(gunsayi.Days.ToString());
			}
			con.Close();
		}
		public void mustericikis(string odano,string kontrol){
			geneltoplam=0;
			if(kontrol=="Color [Red]"){
				siparisucrethesapla(odano);
				odaucrethesapla(odano);
				DialogResult secenek= MessageBox.Show("Odanın "+geneltoplam.ToString()+"TL Ücretinin Tahsil Edildiğini Kontrol Ediniz", "Müşteri Çıkışını Onaylanıyormusunuz?",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
				
				if (secenek == DialogResult.Yes)
				{
					DateTime bugun=DateTime.Today;
					string durum="pasif";
					string odadurum="Müsait";
					try{
						OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open();
						OleDbCommand komut = new OleDbCommand("update musteri set adi=adi,soyadi=soyadi,tcno=tcno,telefon=telefon,dogtarih=dogtarih,odanosu=odanosu,musterino=musterino,cinsiyet=cinsiyet,durum=@durum,giristarih=giristarih,cikistarih=@cikistarih where odanosu='"+odano.ToString()+"' and durum='aktif'", con);
						komut.Parameters.AddWithValue("@durum",durum.ToString());
						komut.Parameters.AddWithValue("@cikistarih",bugun.ToShortDateString());
						komut.ExecuteNonQuery();
						con.Close();
						OleDbConnection bag= new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");bag.Open();
						OleDbCommand commad = new OleDbCommand("update odalar set odaalan=odaalan,odakisisayi=odakisisayi,odano=odano,odakatsayi=odakatsayi,odadurum=@odadurum,odaucret=odaucret,cocuk=cocuk,kirabastarih=kirabastarih,kirabittarih=@kirabittarih,kiragun=0 where odano='"+odano.ToString()+"' ", bag);
						commad.Parameters.AddWithValue("@odadurum",odadurum.ToString());
						commad.Parameters.AddWithValue("@kirabittarih",bugun.ToShortDateString());
						commad.ExecuteNonQuery();
						bag.Close();
						OleDbConnection com = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); com.Open();
						string kayit = "delete from siparis where siparisoda='"+odano.ToString()+"'";
						OleDbCommand komm = new OleDbCommand(kayit, com);
						komm.ExecuteNonQuery();
						com.Close();
						MessageBox.Show("Çıkış Yapıldı");
					}catch{
						MessageBox.Show("Hata");
					}
				}
				else if(secenek==DialogResult.No)
				{
					this.Refresh();
				}
			}else{
				MessageBox.Show("Bu Oda Boş");
			}
		}
		void PictureBox20Click(object sender, EventArgs e)
		{
			
			mustericikis(kartlbl1.Text,kart1.color.ToString());
		}
		
		void PictureBox21Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl2.Text,kart2.color.ToString());
			
		}
		
		void PictureBox22Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl3.Text,kart3.color.ToString());
		}
		
		void PictureBox28Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl4.Text,kart4.color.ToString());
		}
		
		void PictureBox23Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl5.Text,kart5.color.ToString());
		}
		
		void PictureBox24Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl6.Text,kart6.color.ToString());
		}
		
		void PictureBox27Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl7.Text,kart7.color.ToString());
		}
		
		void PictureBox25Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl8.Text,kart8.color.ToString());
		}
		
		void PictureBox26Click(object sender, EventArgs e)
		{
			mustericikis(kartlbl9.Text,kart9.color.ToString());
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void MainLoad(object sender, EventArgs e)
		{
			pictureBox1.Location = new Point ( 20, pictureBox1.Location.Y) ;
			panel1.Size=new Size (50,700);
			panel2.Location= new Point(panel2.Location.X-110,panel2.Location.Y);

		}
		
		void Kartlbl1Click(object sender, EventArgs e)
		{
			
		}
		public void ozellikgoster(string ozellik){
			char[] ayrac = { '*'};
			string[] parcalar = ozellik.Split(ayrac);
			if(parcalar[0].ToString()=="var"){
				pictureBox29.BackgroundImage=Image.FromFile("img/baby.png");
				
			}
			if(parcalar[1].ToString()=="var"){
				pictureBox30.BackgroundImage=Image.FromFile("img/klima.png");
				
			}
			if(parcalar[2].ToString()=="var"){
				pictureBox31.BackgroundImage=Image.FromFile("img/aşk.png");
				
			}
			if(parcalar[3].ToString()=="var"){
				pictureBox32.BackgroundImage=Image.FromFile("img/wifi.png");
				
			}
			if(parcalar[4].ToString()=="var"){
				pictureBox33.BackgroundImage=Image.FromFile("img/teras.png");
				
			}
			if(parcalar[5].ToString()=="var"){
				pictureBox34.BackgroundImage=Image.FromFile("img/vip.png");
				
			}
		}
		public void ozelliksakla(){
			pictureBox29.BackgroundImage=Image.FromFile("img/pasif/p.png");
			pictureBox30.BackgroundImage=Image.FromFile("img/pasif/p.png");
			pictureBox31.BackgroundImage=Image.FromFile("img/pasif/p.png");
			pictureBox32.BackgroundImage=Image.FromFile("img/pasif/p.png");
			pictureBox33.BackgroundImage=Image.FromFile("img/pasif/p.png");
			pictureBox34.BackgroundImage=Image.FromFile("img/pasif/p.png");
		}
		void Kart1MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[0]);
		}
		
		void Kart1MouseLeave(object sender, EventArgs e)
		{
			ozelliksakla();
		}
		
		void Kart2MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[1]);
		}
		
		void Kart3MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[2]);
		}
		
		void Kart4MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[3]);
		}
		
		void Kart5MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[4]);
		}
		
		void Kart6MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[5]);
		}
		
		void Kart7MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[6]);
		}
		
		void Kart8MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[7]);
		}
		
		void Kart9MouseEnter(object sender, EventArgs e)
		{
			ozellikgoster(ozellikler[8]);
		}
		
		void Kart2MouseLeave(object sender, EventArgs e)
		{
			ozelliksakla();
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			randevu fr= new randevu();
			fr.Show();
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			odaislem fr= new odaislem();
			fr.Show();
		}
		
		void BunifuFlatButton4Click(object sender, EventArgs e)
		{
			aktifmusteri fr= new aktifmusteri();
			fr.Show();
		}
		
		void BunifuFlatButton5Click(object sender, EventArgs e)
		{
			yemek fr= new yemek();
			fr.Show();
		}
		
		void BunifuFlatButton6Click(object sender, EventArgs e)
		{
			etkinlik fr= new etkinlik();
			fr.Show();
		}
		
		void BunifuFlatButton7Click(object sender, EventArgs e)
		{
			calisan fr= new calisan();
			fr.Show();
		}
		
		void PictureBox1MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage=Image.FromFile("img/menua.png");
			
		}
		
		void PictureBox1MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage=Image.FromFile("img/menu.png");
		}
		
		void BunifuTileButton1MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton1.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton1MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton1.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTilButton2MouseEnter(object sender, EventArgs e)
		{
			bunifuTilButton2.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTilButton2MouseLeave(object sender, EventArgs e)
		{
			bunifuTilButton2.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTileButton3MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton3.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton3MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton3.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTileButton4MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton4.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton4MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton4.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTileButton5MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton5.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton5MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton5.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTileButton6MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton6.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton6MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton6.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTileButton7MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton7.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton7MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton7.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTileButton8MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton8.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton8MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton8.BackgroundImage=Image.FromFile("img/kat.png");
		}
		
		void BunifuTileButton9MouseEnter(object sender, EventArgs e)
		{
			bunifuTileButton9.BackgroundImage=Image.FromFile("img/kata.png");
		}
		
		void BunifuTileButton9MouseLeave(object sender, EventArgs e)
		{
			bunifuTileButton9.BackgroundImage=Image.FromFile("img/kat.png");
		}

		
		void PictureBox35Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void PictureBox35MouseEnter(object sender, EventArgs e)
		{
			pictureBox35.BackgroundImage=Image.FromFile("img/closea.png");
		}
		
		void PictureBox35MouseLeave(object sender, EventArgs e)
		{
			pictureBox35.BackgroundImage=Image.FromFile("img/pasif/p.png");
		}
		
		void MainMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void MainMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void MainMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
}

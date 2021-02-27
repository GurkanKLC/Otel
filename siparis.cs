
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Otel
{
	/// <summary>
	/// Description of siparis.
	/// </summary>
	public partial class siparis : Form
	{
		static int[] adet;
	    static	string[] isim;
		static  int[] kalori;
		static int[] fiyat;
		static int siparissayi;
		public static string odano="Gelmedi";
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public siparis()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			siparisadet();
			yemekler();
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		public void siparisadet(){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
		OleDbCommand cmd = new OleDbCommand("Select * from siparis where  siparisoda='"+odano.ToString()+"'",con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while(dr.Read()){
        	siparissayi++;
        	
        }
        con.Close();
        siparislistele();
		}
		public void siparislistele(){
	 	adet= new int[siparissayi];
		isim= new string[siparissayi];
		kalori= new int[siparissayi];
		 fiyat= new int[siparissayi];
		int i=0;
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
		OleDbCommand cmd = new OleDbCommand("Select * from siparis where  siparisoda='"+odano.ToString()+"'",con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while(dr.Read()){
        	adet[i]=Convert.ToInt16(dr["adet"].ToString());
        	isim[i]=dr["siparisadi"].ToString();
        	kalori[i]=Convert.ToInt16(dr["kalori"].ToString());
        	fiyat[i]=Convert.ToInt16(dr["ucret"].ToString());
        	bunifuDropdown1.AddItem(dr["siparisadi"].ToString()+"   adet : "+dr["adet"].ToString());
        	i++;
        }
        con.Close();
		}
		

		
		void BunifuDropdown1onItemSelected(object sender, EventArgs e)
		{
			int toplam;
			toplam=fiyat[bunifuDropdown1.selectedIndex]*adet[bunifuDropdown1.selectedIndex];
			label2.Text=isim[bunifuDropdown1.selectedIndex].ToString();
			label3.Text=kalori[bunifuDropdown1.selectedIndex].ToString();
			label4.Text=adet[bunifuDropdown1.selectedIndex].ToString();
			label5.Text=fiyat[bunifuDropdown1.selectedIndex].ToString();
			label11.Text=toplam.ToString();
		}
		
	
		public void yemekler(){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
		OleDbCommand cmd = new OleDbCommand("Select * from yemekler",con);
        OleDbDataReader dr = cmd.ExecuteReader();
       int i=1;
        while(dr.Read()){
             Button btn = new Button();
                btn.Width=120;
                btn.Height=50;
                btn.FlatStyle=FlatStyle.Flat;
                btn.FlatAppearance.BorderSize=0;
                btn.ForeColor=Color.White;
                btn.Text=dr["yemekadi"].ToString();
                btn.Name="btn_" + (i + 1).ToString();
                btn.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                btn.Location=new Point(0,(50*i)-50);
                btn.Click+=siparisekleme;
                panel1.Controls.Add(btn);
                i++;
        }
        con.Close();
       
		}
		
		void siparisekleme(object sender,EventArgs e){
			numericUpDown1.Value=1;
			Button tiklanan=(sender as Button);
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
		OleDbCommand cmd = new OleDbCommand("Select * from yemekler where  yemekadi='"+tiklanan.Text+"'",con);
        OleDbDataReader dr = cmd.ExecuteReader();
        while(dr.Read()){
        	label13.Text=dr["yemekadi"].ToString();
        	label14.Text=dr["kalori"].ToString();
        	label15.Text=dr["adet"].ToString();
        	label16.Text=dr["ucret"].ToString();
        	numericUpDown1.Maximum=Convert.ToInt16(dr["adet"].ToString());
        }
        this.Width=605;
        con.Close();
		}
		public void sipariskaydet(string siparis){
			
	
		}

		
		void SiparisLoad(object sender, EventArgs e)
		{
			
		}
		
	
		
		void BunifuTileButton1Click(object sender, EventArgs e)
		{
			if(this.Width<=300){
				this.Width=446;
			}
			else if(this.Width>300){
				this.Width=300;
			}
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void SiparisMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void SiparisMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void SiparisMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			
			if(bunifuDropdown1.selectedIndex.ToString()!="-1"){
				if(adet[bunifuDropdown1.selectedIndex]>1){
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
            string kayit = "update siparis set adet=@adet where siparisoda='"+odano.ToString()+"' and siparisadi='"+isim[bunifuDropdown1.selectedIndex].ToString()+"'";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            OleDbCommand komut = new OleDbCommand(kayit, con);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adet", adet[bunifuDropdown1.selectedIndex]-1);
            
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            con.Close();
            bunifuDropdown1.Clear();
            siparisadet();
				}else{
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
            string kayit = "delete from siparis where siparisoda='"+odano.ToString()+"' and siparisadi='"+isim[bunifuDropdown1.selectedIndex].ToString()+"'";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            OleDbCommand komut = new OleDbCommand(kayit, con);
             komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            con.Close();
             bunifuDropdown1.Clear();
            siparisadet();
				}
			}else{
				MessageBox.Show("Lütfen Sipariş Seçin");
			}
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
            string kayit = "delete from siparis where siparisoda='"+odano.ToString()+"' and siparisadi='"+isim[bunifuDropdown1.selectedIndex].ToString()+"'";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            OleDbCommand komut = new OleDbCommand(kayit, con);
             komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            con.Close();
             bunifuDropdown1.Clear();
            siparisadet();
		}
		
		void BunifuFlatButton4Click(object sender, EventArgs e)
		{
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");
			OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into siparis(siparisadi,ucret,kalori,siparisoda,adet) values ('"+label13.Text+ "','" + label16.Text + "','" + label14.Text + "','"+odano.ToString()+"','" + Convert.ToString(numericUpDown1.Value) + "')";
            cmd.ExecuteNonQuery(); 
            con.Close();
            bunifuDropdown1.Clear();
            siparisadet();
		}
	}
	
}

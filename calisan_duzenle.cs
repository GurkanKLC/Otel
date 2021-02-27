
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace Otel
{
	/// <summary>
	/// Description of calisan_duzenle.
	/// </summary>
	public partial class calisan_duzenle : Form
	{
		public calisan_duzenle()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb");
		DataTable dt = new DataTable();
		OleDbDataAdapter adapter = new OleDbDataAdapter();

	
				private void isimAra(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM calisan WHERE ad LIKE '%" + bunifuMetroTextbox1.Text.Trim() + "%'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                int count = listView1.Items.Count;
                listView1.Items.Add(okuyucu["id"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["ad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["soyad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["tckimlik_no"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["telefon"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["maas"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["pozisyon"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["isbaslangic"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["cinsiyet"].ToString());
            }
            baglanti.Close();
        }
		
		void Calisan_duzenleLoad(object sender, EventArgs e)
		{
			 listView1.FullRowSelect = true;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Ad");
            listView1.Columns.Add("Soyad");
            listView1.Columns.Add("TC Kimlik");
            listView1.Columns.Add("Telefon");
            listView1.Columns.Add("Maaş");
            listView1.Columns.Add("Pozisyon");
            listView1.Columns.Add("İş Başlangıç");
            listView1.Columns.Add("Cinsiyet");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM calisan", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                int count = listView1.Items.Count;
                listView1.Items.Add(okuyucu["id"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["ad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["soyad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["tckimlik_no"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["telefon"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["maas"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["pozisyon"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["isbaslangic"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["cinsiyet"].ToString());
            }
            baglanti.Close();
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			try{
				if (listView1.SelectedItems.Count == 1)
            {
                string id = listView1.Items[listView1.SelectedItems[0].Index].Text;
                string ad = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                string soyad = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                string tckimlik_no = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                string telefon = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
                string maas = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
                string pozisyon = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;
                string isbaslangic = listView1.Items[listView1.SelectedItems[0].Index].SubItems[7].Text;
                string cinsiyet = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
                bunifuMaterialTextbox6.Text = id;
                bunifuMaterialTextbox1.Text = ad;
                bunifuMaterialTextbox2.Text = soyad;
                bunifuMaterialTextbox3.Text = tckimlik_no;
                bunifuMaterialTextbox4.Text = telefon;
                bunifuMaterialTextbox7.Text = maas;
                bunifuMaterialTextbox5.Text = cinsiyet;
                bunifuMaterialTextbox9.Text = isbaslangic;
                bunifuMaterialTextbox8.Text = pozisyon;
            }
			}
			catch(Exception err){
				MessageBox.Show(err.Message);
			}
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			try
			{
	            baglanti.Open();
	            if (bunifuMaterialTextbox6.Text.Trim() != "")
	            {
	                int id = int.Parse(bunifuMaterialTextbox6.Text);
	                string ad = bunifuMaterialTextbox1.Text.Trim();
	                string soyad = bunifuMaterialTextbox2.Text.Trim();
	                string tckimlik_no = bunifuMaterialTextbox3.Text.Trim();
	                string telefon = bunifuMaterialTextbox4.Text.Trim();
	                string maas = bunifuMaterialTextbox7.Text.Trim();
	                string pozisyon = bunifuMaterialTextbox8.Text.Trim();
	                string isbaslangic = bunifuMaterialTextbox9.Text.Trim();
	                string cinsiyet = bunifuMaterialTextbox5.Text.Trim();
	                if (ad != "" && soyad != "" && tckimlik_no != "")
	                {
	                    OleDbCommand komut = new OleDbCommand("UPDATE calisan SET ad='" + ad + "', soyad='" + soyad + "', tckimlik_no='" + tckimlik_no + "', telefon = '"+ telefon +"', maas = '"+ maas +"', pozisyon = '"+ pozisyon +"', isbaslangic = '"+ isbaslangic +"', cinsiyet = '"+ cinsiyet +"' WHERE id=@id", baglanti);
	                    komut.Parameters.AddWithValue("@id", id);
	                    komut.ExecuteNonQuery();
	                    komut.Dispose();
	                  
	                }
	            }
	        }
			catch (Exception err){
				MessageBox.Show(err.Message);
			}
			finally{
				MessageBox.Show("Düzenleme İşlemi Tamamlandı..");
			}
			  baglanti.Close();
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			 listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Ad");
            listView1.Columns.Add("Soyad");
            listView1.Columns.Add("TC Kimlik");
            listView1.Columns.Add("Telefon");
            listView1.Columns.Add("Maaş");
            listView1.Columns.Add("Pozisyon");
            listView1.Columns.Add("İş Başlangıç");
            listView1.Columns.Add("Cinsiyet");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM calisan ORDER BY ad DESC", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                int count = listView1.Items.Count;
                listView1.Items.Add(okuyucu["id"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["ad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["soyad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["tckimlik_no"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["telefon"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["maas"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["pozisyon"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["isbaslangic"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["cinsiyet"].ToString());
            }
            baglanti.Close();
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

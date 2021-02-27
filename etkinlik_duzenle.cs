/*
 * Created by SharpDevelop.
 * User: G95
 * Date: 5.06.2020
 * Time: 19:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Otel
{
	/// <summary>
	/// Description of etkinlik_duzenle.
	/// </summary>
	public partial class etkinlik_duzenle : Form
	{
		public etkinlik_duzenle()
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

			private void etkinlikAra(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM etkinlikler WHERE etkinlik_adi LIKE '%" + bunifuMetroTextbox1.Text.Trim() + "%'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                int count = listView1.Items.Count;
                listView1.Items.Add(okuyucu["id"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["etkinlik_adi"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["etkinlik_turu"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["baslangic_tarihi"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["bitis_tarihi"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["adsoyad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["numara"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["salon_ucret"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["katilimci_sayisi"].ToString());
            }
            baglanti.Close();
        }

		
		void Etkinlik_duzenleLoad(object sender, EventArgs e)
		{
			
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Etkinlik Adı");
            listView1.Columns.Add("Etkinlik Türü");
            listView1.Columns.Add("Başlangıç Tarihi");
            listView1.Columns.Add("Bitiş Tarihi");
            listView1.Columns.Add("Yetkili Ad Soyad");
            listView1.Columns.Add("İrtibat No");
            listView1.Columns.Add("Salon Ücreti");
            listView1.Columns.Add("Katılımcı Sayısı");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM etkinlikler", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                int count = listView1.Items.Count;
                listView1.Items.Add(okuyucu["id"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["etkinlik_adi"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["etkinlik_turu"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["baslangic_tarihi"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["bitis_tarihi"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["adsoyad"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["numara"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["salon_ucret"].ToString());
                listView1.Items[count].SubItems.Add(okuyucu["katilimci_sayisi"].ToString());
            }
            baglanti.Close();
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
				if (listView1.SelectedItems.Count == 1 )
            {
                string id = listView1.Items[listView1.SelectedItems[0].Index].Text;
                string etkinlik_adi = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                string etkinlik_turu = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                string baslangic_tarihi = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                string bitis_tarihi = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
                string adsoyad = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
                string numara = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;
                string salon_ucret = listView1.Items[listView1.SelectedItems[0].Index].SubItems[7].Text;
                string katilimci_sayisi = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
                bunifuMaterialTextbox1.Text = id;
                bunifuMaterialTextbox2.Text = etkinlik_adi;
                bunifuMaterialTextbox3.Text = etkinlik_turu;
                bunifuMaterialTextbox4.Text = baslangic_tarihi;
                bunifuMaterialTextbox5.Text = bitis_tarihi;
                bunifuMaterialTextbox6.Text = adsoyad;
                bunifuMaterialTextbox7.Text = numara;
                bunifuMaterialTextbox8.Text = salon_ucret;
                bunifuMaterialTextbox9.Text = katilimci_sayisi;
            }		
		}
		
		void BunifuMaterialTextbox8OnValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			try
			{
				
				if (listView1.SelectedItems.Count > 0)
            	{
	                baglanti.Open();
	                foreach (ListViewItem item in listView1.SelectedItems)
		            {
	                    int id = int.Parse(item.Text);
	                    OleDbCommand komut = new OleDbCommand("DELETE FROM etkinlikler WHERE id=@id", baglanti);
	                    komut.Parameters.AddWithValue("@id", id);
	                    komut.ExecuteNonQuery();
	                    komut.Dispose();
		            }
	                baglanti.Close();
           	    }
			}
			catch(Exception err){
				MessageBox.Show(err.Message);
			}
			finally{
				MessageBox.Show("Silme İşlemi Tamamlandı..");
			}
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			try
			{
	            baglanti.Open();
	            if (bunifuMaterialTextbox1.Text.Trim() != "")
	            {
	                int id = int.Parse(bunifuMaterialTextbox1.Text);
	                string etkinlik_adi = bunifuMaterialTextbox2.Text.Trim();
	                string etkinlik_turu = bunifuMaterialTextbox3.Text.Trim();
	                string baslangic_tarihi = bunifuMaterialTextbox4.Text.Trim();
	                string bitis_tarihi = bunifuMaterialTextbox5.Text.Trim();
	                string adsoyad = bunifuMaterialTextbox6.Text.Trim();
	                string numara = bunifuMaterialTextbox7.Text.Trim();
	                string salon_ucret = bunifuMaterialTextbox8.Text.Trim();
	                string katilimci_sayisi = bunifuMaterialTextbox9.Text.Trim();
	                if (etkinlik_adi != "" && adsoyad != "" && numara != "")
	                {
	                    OleDbCommand komut = new OleDbCommand("UPDATE etkinlikler SET etkinlik_adi='" + etkinlik_adi + "', etkinlik_turu = '" + etkinlik_turu + "', baslangic_tarihi = '" + baslangic_tarihi + "', bitis_tarihi = '" + bitis_tarihi + "', adsoyad = '" + adsoyad +"', numara='" + numara + "', salon_ucret = '"+ salon_ucret +"', katilimci_sayisi = '"+ katilimci_sayisi +"' WHERE id=@id", baglanti);
	                    komut.Parameters.AddWithValue("@id", id);
	                    komut.ExecuteNonQuery();
	                    komut.Dispose();
	                    baglanti.Close();
	                }
	            }
	        }
			catch (Exception err){
				MessageBox.Show(err.Message);
			}
			finally{
				MessageBox.Show("Düzenleme İşlemi Tamamlandı..");
			}
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

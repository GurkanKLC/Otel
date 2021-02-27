
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace Otel
{
	/// <summary>
	/// Description of calisan_sil.
	/// </summary>
	public partial class calisan_sil : Form
	{
		public calisan_sil()
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

		
		void Calisan_silLoad(object sender, EventArgs e)
		{
			listele();
		}
		public void listele(){
			listView1.Clear();
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
	                    OleDbCommand komut = new OleDbCommand("DELETE FROM calisan WHERE id=@id", baglanti);
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
				
				listele();
			}
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

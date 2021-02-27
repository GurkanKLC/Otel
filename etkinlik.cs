/*
 * Created by SharpDevelop.
 * User: G95
 * Date: 5.06.2020
 * Time: 19:28
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
	/// Description of etkinlik.
	/// </summary>
	public partial class etkinlik : Form
	{
		public etkinlik()
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
		
		void EtkinlikLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Konferans / Seminer");
			comboBox1.Items.Add("Nişan / Düğün");
			comboBox1.Items.Add("Toplantı");
			comboBox1.Items.Add("Havuz Partisi");
			comboBox1.Items.Add("Küstüm Show");
			comboBox1.Items.Add("Konser");
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			try
			{
				if (bunifuMaterialTextbox1.Text.Trim() != "" && bunifuMaterialTextbox2.Text.Trim() != "" && bunifuMaterialTextbox3.Text.Trim() != "")
	            {
	            	baglanti.Open();
	                OleDbCommand komut = new OleDbCommand("INSERT INTO etkinlikler (etkinlik_adi, etkinlik_turu, baslangic_tarihi, bitis_tarihi, adsoyad, numara, salon_ucret, katilimci_sayisi) VALUES ('"+bunifuMaterialTextbox1.Text+"','"+comboBox1.Text+"','"+dateTimePicker1.Value+"','"+dateTimePicker2.Value+"','"+bunifuMaterialTextbox2.Text+"','"+bunifuMaterialTextbox3.Text+"','"+bunifuMaterialTextbox4.Text+"', '"+bunifuMaterialTextbox5.Text+"')",baglanti);
	                komut.Parameters.AddWithValue("@etkinlik_adi", bunifuMaterialTextbox1.Text);
	                komut.Parameters.AddWithValue("@etkinlik_turu", comboBox1.Text);
	                komut.Parameters.AddWithValue("@baslangic_tarihi", Convert.ToDateTime(dateTimePicker1.Value));
	                komut.Parameters.AddWithValue("@bitis_tarihi",Convert.ToDateTime(dateTimePicker2.Value));
	                komut.Parameters.AddWithValue("@adsoyad", bunifuMaterialTextbox2.Text);
	                komut.Parameters.AddWithValue("@numara", bunifuMaterialTextbox3.Text);
	                komut.Parameters.AddWithValue("@salon_ucret",bunifuMaterialTextbox4.Text);
	                komut.Parameters.AddWithValue("@katilimci_sayisi", bunifuMaterialTextbox5.Text);
	                komut.ExecuteNonQuery();
	                komut.Dispose();
	                baglanti.Close();
	            }
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
			finally{
				MessageBox.Show("Ekleme İşlemi Tamamlandı..");
			}
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
				etkinlik_duzenle duzenleEtkinlik = new etkinlik_duzenle();
			duzenleEtkinlik.Show();
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

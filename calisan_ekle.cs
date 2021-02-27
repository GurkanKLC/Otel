
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace Otel
{
	/// <summary>
	/// Description of calisan_ekle.
	/// </summary>
	public partial class calisan_ekle : Form
	{
		public calisan_ekle()
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

		void Calisan_ekleLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Temizlik Görevilisi");
			comboBox1.Items.Add("Aşçı");
			comboBox1.Items.Add("Resepsiyon");
			comboBox1.Items.Add("Vale");
			comboBox1.Items.Add("Garson");
			comboBox1.Items.Add("Şef Garson");
			comboBox1.Items.Add("Müdür");
		}
		
		void Label11Click(object sender, EventArgs e)
		{
			
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
				try
			{
				if (bunifuMaterialTextbox10.Text.Trim() != "" && bunifuMaterialTextbox11.Text.Trim() != "" && bunifuMaterialTextbox12.Text.Trim() != "")
	            {
					string cinsiyet = "";
	                if(radioButton1.Checked){
	                	cinsiyet = "Kadın";
	                }
	                if(radioButton2.Checked){
	                	cinsiyet = "Erkek";
	                }
	            	baglanti.Open();
	                OleDbCommand komut = new OleDbCommand("INSERT INTO calisan (ad, soyad, tckimlik_no, telefon, maas, pozisyon, isbaslangic, cinsiyet) VALUES (@ad, @soyad, @tckimlik_no, @telefon, @maas, @pozisyon, @isbaslangic, @cinsiyet)",baglanti);
	                komut.Parameters.AddWithValue("@ad", bunifuMaterialTextbox10.Text);
	                komut.Parameters.AddWithValue("@soyad", bunifuMaterialTextbox11.Text);
	                komut.Parameters.AddWithValue("@tckimlik_no", Convert.ToDecimal(bunifuMaterialTextbox12.Text));
	                komut.Parameters.AddWithValue("@telefon",Convert.ToDecimal(bunifuMaterialTextbox13.Text));
	                komut.Parameters.AddWithValue("@maas",Convert.ToDouble(bunifuMaterialTextbox14.Text));
	                komut.Parameters.AddWithValue("@pozisyon",comboBox1.Text);
	                komut.Parameters.AddWithValue("@isbaslangic",Convert.ToDateTime(bunifuDatepicker1.Value.ToShortDateString()));
	                komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
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
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

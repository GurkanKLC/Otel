/*
 * Created by SharpDevelop.
 * User: G95
 * Date: 5.06.2020
 * Time: 19:21
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
	/// Description of yemek.
	/// </summary>
	public partial class yemek : Form
	{
			private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public yemek()
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

		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			
				try
			{
				if (bunifuMaterialTextbox1.Text.Trim() != "" && bunifuMaterialTextbox2.Text.Trim() != "" && bunifuMaterialTextbox3.Text.Trim() != "")
	            {
	            	baglanti.Open();
	                OleDbCommand komut = new OleDbCommand("INSERT INTO yemekler (yemekadi, kalori, ucret, adet) VALUES (@yemekadi, @kalori, @ucret, @adet)",baglanti);
	                komut.Parameters.AddWithValue("@yemekadi", bunifuMaterialTextbox1.Text);
	                komut.Parameters.AddWithValue("@kalori",Convert.ToDouble(bunifuMaterialTextbox2.Text));
	                komut.Parameters.AddWithValue("@ucret", Convert.ToDouble(bunifuMaterialTextbox3.Text));
	                komut.Parameters.AddWithValue("@adet",bunifuMaterialTextbox4.Text);
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
			yemek_duzenle duzenleYemek = new yemek_duzenle();
			duzenleYemek.Show();
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void YemekMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void YemekMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void YemekMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
}

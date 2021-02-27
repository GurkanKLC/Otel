/*
 * Created by SharpDevelop.
 * User: G95
 * Date: 5.06.2020
 * Time: 19:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace Otel
{
	/// <summary>
	/// Description of yemek_duzenle.
	/// </summary>
	public partial class yemek_duzenle : Form
	{
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public yemek_duzenle()
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

		private void yemekAra(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			baglanti.Open();
			OleDbCommand komut = new OleDbCommand("SELECT * FROM yemekler WHERE yemekadi LIKE '%" + bunifuMaterialTextbox6.Text.Trim() + "%'", baglanti);
			OleDbDataReader okuyucu = komut.ExecuteReader();
			while (okuyucu.Read())
			{
				int count = listView1.Items.Count;
				listView1.Items.Add(okuyucu["yemekid"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["yemekadi"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["kalori"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["ucret"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["adet"].ToString());
				
			}
			baglanti.Close();
		}

		public void yemekekle(){
			listView1.Clear();
			listView1.FullRowSelect = true;
			listView1.Columns.Add("ID");
			listView1.Columns.Add("Besin Adı");
			listView1.Columns.Add("Kalori");
			listView1.Columns.Add("Ücret");
			listView1.Columns.Add("Adet");
			baglanti.Open();
			OleDbCommand komut = new OleDbCommand("SELECT * FROM yemekler", baglanti);
			OleDbDataReader okuyucu = komut.ExecuteReader();
			while (okuyucu.Read())
			{
				int count = listView1.Items.Count;
				listView1.Items.Add(okuyucu["yemekid"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["yemekadi"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["kalori"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["ucret"].ToString());
				listView1.Items[count].SubItems.Add(okuyucu["adet"].ToString());
			}
			baglanti.Close();
		}
		void Yemek_duzenleLoad(object sender, EventArgs e)
		{
			
			yemekekle();
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			try{
				if (listView1.SelectedItems.Count == 1)
				{
					string yemekid = listView1.Items[listView1.SelectedItems[0].Index].Text;
					string yemekadi = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
					string kalori = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
					string ucret = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
					string adet = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
					bunifuMaterialTextbox1.Text = yemekid;
					bunifuMaterialTextbox2.Text = yemekadi;
					bunifuMaterialTextbox4.Text = kalori;
					bunifuMaterialTextbox3.Text = ucret;
					bunifuMaterialTextbox5.Text = adet;
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
				if (bunifuMaterialTextbox1.Text.Trim() != "")
				{
					int yemekid = int.Parse(bunifuMaterialTextbox1.Text);
					string yemekadi = bunifuMaterialTextbox2.Text.Trim();
					string kalori = bunifuMaterialTextbox4.Text.Trim();
					string ucret = bunifuMaterialTextbox3.Text.Trim();
					string adet = bunifuMaterialTextbox5.Text.Trim();
					if (yemekadi != "" && kalori != "" && ucret != "")
					{
						OleDbCommand komut = new OleDbCommand("UPDATE yemekler SET yemekadi='" + yemekadi + "', kalori='" + kalori + "', ucret='" + ucret + "', adet='"+ adet +"' WHERE yemekid=@yemekid", baglanti);
						komut.Parameters.AddWithValue("@yemekid", yemekid);
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
			yemekekle();
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
						OleDbCommand komut = new OleDbCommand("DELETE FROM yemekler WHERE yemekid=@yemekid", baglanti);
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
			yemekekle();
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void Yemek_duzenleMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		
		void Yemek_duzenleMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		
		void Yemek_duzenleMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
		

	}
}

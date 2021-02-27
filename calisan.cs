/*
 * Created by SharpDevelop.
 * User: G95
 * Date: 5.06.2020
 * Time: 19:36
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
	/// Description of calisan.
	/// </summary>
	public partial class calisan : Form
	{
		public calisan()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			calisan_ekle yeniCalisan = new calisan_ekle();
			yeniCalisan.Show();
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			calisan_sil silCalisan = new calisan_sil();
			silCalisan.Show();
		}
		
		void BunifuFlatButton3Click(object sender, EventArgs e)
		{
			calisan_duzenle yeniCalisan = new calisan_duzenle();
			yeniCalisan.Show();
		}
		
		void BunifuFlatButton4Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;
namespace Otel
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		void MainFormLoad(object sender, EventArgs e)
		{
			bunifuMaterialTextbox1.Text="g95";
			bunifuMaterialTextbox2.Text="15250";
		}
		
		void BunifuFlatButton1Click(object sender, EventArgs e)
		{
			
			 OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otel1.accdb"); con.Open(); 
          //  OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Dosya.mdb"); con.Open();//
            OleDbCommand cmd = new OleDbCommand("Select kullaniciadi, sifre,isim from admin where kullaniciadi='"+bunifuMaterialTextbox1.Text+"' and sifre='"+bunifuMaterialTextbox2.Text+"'",con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if(dr.Read()){
            	Main form2 = new Main();
                form2.Show(); //form2 göster diyoruz
                this.Hide();
                
            }
            else{
            	label1.Text="Yanlış";
            	bunifuMaterialTextbox1.BackColor=Color.Red;
            }
            con.Close();
		}
		
		void BunifuFlatButton2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

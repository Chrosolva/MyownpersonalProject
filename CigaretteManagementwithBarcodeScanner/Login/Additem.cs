using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Additem : Form
    {
        public Additem()
        {
            InitializeComponent();
            
            DGVforRak.BorderStyle = BorderStyle.None;
            DGVforRak.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVforRak.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DGVforRak.EnableHeadersVisualStyles = false;
            DGVforRak.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVforRak.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DGVforRak.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVforRak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVforRak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVforRak.MultiSelect = false;

            RDGVForRak.BorderStyle = BorderStyle.None;
            RDGVForRak.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            RDGVForRak.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            RDGVForRak.EnableHeadersVisualStyles = false;
            RDGVForRak.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            RDGVForRak.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            RDGVForRak.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            RDGVForRak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RDGVForRak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RDGVForRak.MultiSelect = false;

            ConnectDB databaseconnection = new ConnectDB();
            MySqlDataAdapter adapter,adapter2;
            if (databaseconnection.OpenConnection() == true) {
                adapter = new MySqlDataAdapter("SELECT * FROM `rak` WHERE  `rak`.`ID_Rak` LIKE 'L%' ", databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DGVforRak.DataSource = ds.Tables[0];
                adapter2 = new MySqlDataAdapter("SELECT * FROM `rak` WHERE  `rak`.`ID_Rak` LIKE 'R%'", databaseconnection.connection);
                DataSet dss = new DataSet();
                adapter2.Fill(dss);
                RDGVForRak.DataSource = dss.Tables[0]; 
                databaseconnection.CloseConnection(); 
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txt_scannedcode_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_scannedcode_KeyUp(object sender, KeyEventArgs e)
        {
            DetailBahan detailbahan = new DetailBahan();
            detailbahan.getAllBahan();
            DetailRak detailrak = new DetailRak();
            detailrak.getallisiRak();
            int byk = detailrak.countallisirak(); 
            if (e.KeyCode == Keys.Enter) {

                Bahan masuk = new Bahan();
                foreach (Bahan i in detailbahan.lstbhn)
                {
                    if (txt_scannedcode.Text == i.ID_Bahan.ToString())
                    {
                        masuk = new Bahan(i.ID_Bahan, i.Nama_Bahan, i.Grade);
                        break;
                    }
                }
                

                Rak temp = new Rak();
                if (byk % 2 == 0)
                {
                    foreach (Rak j in detailrak.listrak)
                    {
                        if (j.ID_Bahan == 0)
                        {
                            temp.setIDrak(j);
                            temp.setIDBahan(j);
                            break;
                        }
                    }
                }
                else {
                    foreach (Rak j in detailrak.listrakR)
                    {
                        if (j.ID_Bahan == 0)
                        {
                            temp.setIDrak(j);
                            temp.setIDBahan(j);
                            break;
                        }
                    }
                }

                
                ConnectDB databaseconnection = new ConnectDB();
                if (true)
                {
                    databaseconnection.Update(temp.InsertintoDrawer(temp.ID_rak, masuk));
                    
                    txt_scannedcode.Text = "";
                    Additem ad = new Additem();
                    ad.Show();
                    this.Hide();
                }
                
            }
        }

        private void DGVforRak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVforRak.ReadOnly = true; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Additem_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1); 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RDGVForRak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RDGVForRak.ReadOnly = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

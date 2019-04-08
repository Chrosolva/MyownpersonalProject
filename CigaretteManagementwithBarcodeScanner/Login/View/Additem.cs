using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Login
{
    public partial class Additem : Form
    {
        private DetailBahan detailbahan; 
        private DetailRak detailrak;
        public ConnectDB objConnection;
        public DataTable dt= new DataTable();
        public DataTable leftdrawer =new DataTable();
        public DataTable rightdrawer = new DataTable();
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
            this.FillDGV();
            
            objConnection = new ConnectDB(); 
            
        }

        public void FillDGV()
        {
            ConnectDB databaseconnection = new ConnectDB();
            SqlDataAdapter adapter, adapter2;
            if (databaseconnection.OpenConnection() == true)
            {
                adapter = new SqlDataAdapter("SELECT * FROM rak WHERE  rak.ID_Rak LIKE 'L%' ", databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DGVforRak.DataSource = ds.Tables[0];
                adapter2 = new SqlDataAdapter("SELECT * FROM rak WHERE  rak.ID_Rak LIKE 'R%'", databaseconnection.connection);
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
            if (e.KeyCode == Keys.Enter && txt_scannedcode.TextLength==8)
            {
                string now = DateTime.Now.Year.ToString()+"-"+DateTime.Now.Month.ToString()+"-"+DateTime.Now.Day.ToString();
                
                string query = "Select * From Bahan where ID_Bahan = '"+txt_scannedcode.Text+"';";
                dt = objConnection.FillDataTable(query);
                query = "Select Count(*) From Rak where ID_Bahan != '0' and ID_Rak Like 'L%';";
                int countkiri = objConnection.countdata(query);
                query = "Select Count(*) From Rak Where ID_Bahan !='0' and ID_Rak Like'R%';";
                int countkanan = objConnection.countdata(query);
                label_ID.Text = dt.Rows[0][0].ToString();
                label_Name.Text = dt.Rows[0][1].ToString();
                label_Grade.Text = dt.Rows[0][2].ToString();
                if (countkiri > countkanan && countkiri <= 75)
                {
                    try
                    {
                        query = "Select * From Rak where ID_Rak Like 'R%'";
                        rightdrawer = objConnection.FillDataTable(query);
                        foreach (DataRow x in rightdrawer.Rows)
                        {
                            if (x["ID_Bahan"].ToString().Equals("0"))
                            {
                                objConnection.Update("Update Rak set Rak.ID_Bahan = '" + dt.Rows[0][0].ToString() + "', Rak.Tanggal_Masuk = '" + now + "' where Rak.ID_Rak = '" + x["ID_Rak"].ToString() + "';");
                                txt_scannedcode.Text = ""; 
                                break;
                            }
                            
                        }
                        
                    }
                    catch (Exception er)
                    {
                        throw er;
                    }
                }
                else if (countkanan <= countkiri && countkanan <= 74)
                {
                    try
                    {
                        query = "Select * From Rak where ID_Rak Like 'L%'";
                        leftdrawer = objConnection.FillDataTable(query);
                        foreach (DataRow x in leftdrawer.Rows)
                        {
                            if (x["ID_Bahan"].ToString().Equals("0"))
                            {
                                objConnection.Update("Update Rak set Rak.ID_Bahan = '" + dt.Rows[0][0].ToString() + "', Rak.Tanggal_Masuk = '" + now + "' where Rak.ID_Rak = '" + x["ID_Rak"].ToString() + "';");
                                txt_scannedcode.Text = "";
                                
                                break;
                            }
                            
                        }
                        
                    }
                    catch (Exception er)
                    {
                        throw er;
                    }
                }
                else
                    MessageBox.Show("Rak Penuh"); 

            }
            this.FillDGV();
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
            SendLocation frmSendlocation = new SendLocation();
            frmSendlocation.Show();
            this.Hide();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

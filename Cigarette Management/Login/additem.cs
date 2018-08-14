using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class additem : Form
    {
        public additem()
        {
            InitializeComponent();
            
            //DATA GRID VIEW PROPERTIES 
            showbahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE 
            showbahan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            showbahan.MultiSelect = false;
            ConnectDB databaseconnection = new ConnectDB();
            MySqlDataAdapter adapter;
            if (databaseconnection.OpenConnection() == true)
            {
                adapter = new MySqlDataAdapter("SELECT * FROM `bahan` ", databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                showbahan.DataSource = ds.Tables[0];
                //close connection 
                databaseconnection.CloseConnection();
            }
    }
        private Bahan tempp; 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void additem_Load(object sender, EventArgs e)
        {

        }

        private void btn_searchbahan_Click(object sender, EventArgs e)
        {
            string keyword = txt_listbahan.Text;
            ConnectDB databaseconnection = new ConnectDB();
            MySqlDataAdapter adapter;
            if (databaseconnection.OpenConnection() == true)
            {
                adapter = new MySqlDataAdapter("SELECT * FROM `bahan` WHERE `bahan`.`Nama_Bahan`= '" + keyword.ToString() + "';", databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                showbahan.DataSource = ds.Tables[0];
                //close connection 
                databaseconnection.CloseConnection();
            }
        }

        private void txt_listbahan_MouseClick(object sender, MouseEventArgs e)
        {
            txt_listbahan.Text = ""; 
        }

        private void txt_listbahan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txt_listbahan.Text;
                ConnectDB databaseconnection = new ConnectDB();
                MySqlDataAdapter adapter;
                if (databaseconnection.OpenConnection() == true)
                {
                    adapter = new MySqlDataAdapter("SELECT * FROM `bahan` WHERE `bahan`.`Nama_Bahan`= '" + keyword.ToString() + "';", databaseconnection.connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    showbahan.DataSource = ds.Tables[0];
                    //close connection 
                    databaseconnection.CloseConnection();
                }
            }

        }

        private void btn_addbahan_Click(object sender, EventArgs e)
        {
            Addbahan adbhn = new Addbahan();
            adbhn.Show();
            this.Hide();
        }

        private void showbahan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; // get the row index 
            DataGridViewRow selectedrow = showbahan.Rows[index];
            int idbahan = (int)selectedrow.Cells[0].Value;
            string namabahan = selectedrow.Cells[1].Value.ToString();
            tempp = new Bahan(idbahan, namabahan); 
            
        }

        private void btn_insertdrawer_Click(object sender, EventArgs e)
        {
            List<rak> listrak = new List<rak>();
            ConnectDB databaseconnection = new ConnectDB();
            MySqlCommand myCommand = (MySqlCommand)databaseconnection.connection.CreateCommand();
            myCommand.CommandText = "SELECT * FROM `rak`";
            databaseconnection.OpenConnection();
            MySqlDataReader reader = myCommand.ExecuteReader();
            try
            {
                //Always Call Read Before Accessing Data 
                while (reader.Read())
                {
                    if (reader.GetInt32(1)!=null)
                    {
                        listrak.Add(new rak(reader.GetString(0), reader.GetInt32(1), reader.GetString(2), (reader.GetDateTime(3))));
                    }
                    else {
                        DateTime tmp = new DateTime();
                        tmp = DateTime.Today.Date; 
                        listrak.Add(new rak(reader.GetString(0), reader.GetInt32(1), reader.GetString(2),tmp));
                    }
                }
            }
            finally
            {
                //Always Call Close when done reading. 
                reader.Close();
                //Close Connection when done with it 
                databaseconnection.CloseConnection();
            }

            foreach (rak x in listrak)
            {
                if (x.Nama_Bahan == "NULL")
                {
                    databaseconnection.OpenConnection();
                    databaseconnection.Update(x.InsertintoDrawer(x.ID_rak, tempp));
                    databaseconnection.CloseConnection();
                    MessageBox.Show("Berhasil"); 
                    break;
                }
                else
                {
                    MessageBox.Show("Rak Penuh!!!");
                }
            }
        }
    }
}
    
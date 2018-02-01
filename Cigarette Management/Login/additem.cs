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
    }
}

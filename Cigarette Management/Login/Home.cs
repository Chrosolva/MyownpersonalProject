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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //DATA GRID VIEW PROPERTIES 
            showdrawer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE 
            showdrawer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            showdrawer.MultiSelect = false; 
            ConnectDB databaseconnection = new ConnectDB();
            MySqlDataAdapter adapter;
            if (databaseconnection.OpenConnection() == true) {
                adapter = new MySqlDataAdapter("SELECT * FROM `rak`", databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                showdrawer.DataSource = ds.Tables[0];
                //close connection 
                databaseconnection.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            additem additm = new additem();
            additm.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_srch.Text;
            string query = "SELECT * FROM `rak` WHERE `rak`.`Nama_Bahan`= '" + keyword.ToString() + "';";
            if (keyword == "") {
                query = "SELECT * FROM `rak`"; 
            }
            ConnectDB databaseconnection = new ConnectDB();
            MySqlDataAdapter adapter;
            if (databaseconnection.OpenConnection() == true)
            {
                adapter = new MySqlDataAdapter(query, databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                showdrawer.DataSource = ds.Tables[0];
                //close connection 
                databaseconnection.CloseConnection();
                txt_srch.Text = "";
            }
        }

        private void txt_srch_MouseClick(object sender, MouseEventArgs e)
        {
            txt_srch.Text = "";
        }

        private void txt_srch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string keyword = txt_srch.Text;
                string query = "SELECT * FROM `rak` WHERE `rak`.`Nama_Bahan`= '" + keyword.ToString() + "';";
                if (keyword == "")
                {
                    query = "SELECT * FROM `rak`";
                }
                ConnectDB databaseconnection = new ConnectDB();
                MySqlDataAdapter adapter;
                if (databaseconnection.OpenConnection() == true)
                {
                    adapter = new MySqlDataAdapter(query, databaseconnection.connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    showdrawer.DataSource = ds.Tables[0];
                    //close connection 
                    databaseconnection.CloseConnection();
                    txt_srch.Text = "";
                }
            }
        }

        private void txt_srch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

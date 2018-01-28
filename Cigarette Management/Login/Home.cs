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
                adapter = new MySqlDataAdapter("SELECT `rak`.`ID_Rak`,`rak`.`Nama_Bahan`,`rak`.`Tanggal_Masuk` FROM `rak` WHERE `rak`.`ID_Bahan`!='' ", databaseconnection.connection);
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
    }
}

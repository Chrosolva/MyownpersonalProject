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
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        private void MakeRecipe_Load(object sender, EventArgs e)
        {
            

            ConnectDB databaseconnection = new ConnectDB();
            MySqlDataAdapter adapter;
            if (databaseconnection.OpenConnection() == true)
            {
                adapter = new MySqlDataAdapter("SELECT DISTINCT `resep`.`nama_resep` FROM `resep` WHERE `resep`.`Grade`!='' ;", databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds,"resep");
                Dgvforrecipelist.DataSource = ds.Tables[0];
                databaseconnection.CloseConnection();
            }
            DataGridViewButtonColumn dgvbtn = new DataGridViewButtonColumn();
            dgvbtn.UseColumnTextForButtonValue = true;
            Dgvforrecipelist.Columns.Add(dgvbtn);
            dgvbtn.Name = "dgvbtn";
            dgvbtn.Text = "Send Location";
            dgvbtn.HeaderText = "";
            Dgvforrecipelist.AllowUserToAddRows = false;
            Dgvforrecipelist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;
            List<Bahan> tmp = new List<Bahan>();
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                //SendLocation 
                SendLocation sndl = new SendLocation(); 
                
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Createrecipe crt = new Createrecipe();
            crt.Show();  
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Recipes rsp = new Recipes();
            rsp.Show();
        }

        private void Recipes_Click(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_delete.Enabled = false; 
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close(); 
        } 

    }
}

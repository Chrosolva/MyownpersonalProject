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
    public partial class Createrecipe : Form
    {
        public Createrecipe()
        {
            InitializeComponent();
            this.Fillcbx();
            ConnectDB databaseconnection = new ConnectDB();
            MySqlDataAdapter adapter;
            if (databaseconnection.OpenConnection() == true)
            {
                adapter = new MySqlDataAdapter("SELECT * FROM `bahan`; ", databaseconnection.connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DGVforIngredientsList.DataSource = ds.Tables[0];
                databaseconnection.CloseConnection();
            }
            DataGridViewCheckBoxColumn dgvcmb = new DataGridViewCheckBoxColumn();
            dgvcmb.ValueType = typeof(bool);
            dgvcmb.Name = "Checkbox";
            dgvcmb.HeaderText = "Select";
            dgvcmb.FalseValue = false; 
            DGVforIngredientsList.Columns.Add(dgvcmb);
            DGVforIngredientsList.AllowUserToAddRows = false;
            DGVforIngredientsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DGVforIngredientsList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        public void Fillcbx() {
            ConnectDB databaseconnection = new ConnectDB();
            if (databaseconnection.OpenConnection() == true)
            {
                string query = "Select * from rokok ;";
                

                DataTable dt = new DataTable("rokok");
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, databaseconnection.connectionString))
                {
                    da.Fill(dt);
                }

                foreach (DataRow x in dt.Rows)
                {
                    cbxRokok.Items.Add(x["Nama_Rokok"].ToString());
                }
            }
        }

        public void browseclick() {
            Rokok rokok = new Rokok();
            rokok.getAllrokok();
            bool ada = true;
            foreach (Rokok x in rokok.lstrokok)
            {
                if (x.Nama_rokok.ToUpper() == txt_namarokok.Text.ToUpper())
                {
                    lbl_foridrokok.Text = x.Id_rokok.ToString();
                    txt_namarokok.Text = x.Nama_rokok;
                    ada = true;
                    break;
                }
                else
                {
                    ada = false;
                    continue;
                }

            }
            if (ada == false)
            {
                int idx = rokok.getLatestID();
                lbl_foridrokok.Text = idx.ToString();
                ConnectDB databaseconnection = new ConnectDB();
                string query = "Insert into rokok (ID_Rokok,Nama_Rokok) Values (" + Convert.ToInt32(idx).ToString() + ",'" + txt_namarokok.Text.ToString() + "');";
                databaseconnection.Insert(query);
            }
            ada = true;
        }


        private void btn_create_Click(object sender, EventArgs e)
        {
            Recipe resep = new Recipe();
            if (resep.Checkrecipe(txt_recipename.Text) == true)
            {
                MessageBox.Show("Resep sudah ada");
            }
            else {
                DetailBahan x = new DetailBahan();
                for (int i = 0; i < DGVforIngredientsList.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = DGVforIngredientsList.Rows[i];
                    if (row.Cells["Checkbox"].Value == null)
                        continue;
                    else if ((bool)(row.Cells["Checkbox"]).Value
                        || (CheckState)row.Cells["Checkbox"].Value == CheckState.Checked)
                    {
                        Bahan bhn = new Bahan(Convert.ToInt32(row.Cells[1].Value), row.Cells[2].Value.ToString(), Convert.ToChar(row.Cells[3].Value));
                        x.lstbhn.Add(bhn);
                    }
                }
                Rokok tmp = new Rokok();
                tmp = new Rokok(Convert.ToInt32(lbl_foridrokok.Text), txt_namarokok.Text);
                resep = new Recipe(txt_recipename.Text, x, tmp);
                resep.CreateRecipe();
                MessageBox.Show("Recipe Created");
                this.Hide();
            }

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            this.browseclick(); 
        }

        private void cbxRokok_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_namarokok.Text = cbxRokok.SelectedItem.ToString();
            this.browseclick();
        }
    }
}

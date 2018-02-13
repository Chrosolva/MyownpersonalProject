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
    public partial class Addbahan : Form
    {
        public Addbahan()
        {
            InitializeComponent();
            
            
        }

        private void Addbahan_Load(object sender, EventArgs e)
        {

        }

        private void txt_namabahan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addbahan_Click(object sender, EventArgs e)
        {
            ConnectDB databaseconnection = new ConnectDB();
            if (txt_namabahan.Text != "") {
                Bahan temp = new Bahan(txt_namabahan.Text);
                databaseconnection.Insert(temp.insertBahan());
                databaseconnection.CloseConnection(); 
                
                this.Hide();
                additem additem = new additem();
                additem.Show(); 
            }
             
        }
    }
}

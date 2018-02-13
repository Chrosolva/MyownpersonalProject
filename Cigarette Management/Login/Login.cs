using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginUser lgn = new LoginUser();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUser lgn = new LoginUser();
            bool masuk;
            masuk = lgn.checkLogin(txt_username.Text, txt_password.Text);
            if (masuk)
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else {
                MessageBox.Show("Periksa kembali username dan password");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
             
        }

        private void btn_submit_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Periksa kembali username dan password");
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
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
                else
                {
                    MessageBox.Show("Periksa kembali username dan password");
                } 
                //testing test = new testing();
                //test.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

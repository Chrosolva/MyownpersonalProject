using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class User
    {
        public int Iduser { private set; get;  } 
        public string username { private set; get; } 
        public string password { private set; get; } 
        public string address { private set; get; } 
        public bool role { private set; get; }

        public User(int Iduser, string username, string password, string address, bool roled) {
            this.Iduser = Iduser; 
            this.username = username;
            this.password = password;
            this.address = address;
            this.role = roled; 
        }

        public User( string username, string password, string address, bool roled)
        {
            this.username = username;
            this.password = password;
            this.address = address;
            this.role = roled;
        }

        public int getId() {
            return this.Iduser; 
        }

        public string getname() {
            return this.username; 
        }
        public string getpass() {
            return this.password; 
        }

        public string getadd() {
            return this.address; 
        }

        public bool getrole() {
            return this.role; 
        }

    }
}

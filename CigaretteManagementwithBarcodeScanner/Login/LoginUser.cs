using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login
{
    class LoginUser
    {
        public List<User> listuser;
        public LoginUser()
        {
            listuser = new List<User>();
            string sql = "SELECT * FROM `user`;";
            ConnectDB databaseconnection = new ConnectDB();
            MySqlCommand myCommand = (MySqlCommand)databaseconnection.connection.CreateCommand();
            myCommand.CommandText = sql;
            databaseconnection.OpenConnection();
            MySqlDataReader reader = myCommand.ExecuteReader();
            try
            {
                //Always Call Read Before Accessing Data 
                while (reader.Read())
                {
                    listuser.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4)));
                }
            }
            finally
            {
                //Always Call Close when done reading. 
                reader.Close();
                //Close Connection when done with it 
                databaseconnection.CloseConnection();
            }
        }

        public bool checkLogin(string username, string password)
        {
            bool masuk = false;
            foreach (User x in listuser)
            {
                if (username == x.getname() && password == x.getpass())
                {

                    masuk = true;
                    break;
                }
                else
                {
                    masuk = false;
                }
            }
            return masuk;

        }

    }
}

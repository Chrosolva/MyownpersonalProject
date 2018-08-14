using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login
{
    class DetailRak
    {
        public List<Rak> listrak;
        public List<Rak> listrakR; 

        public DetailRak() {
            listrak = new List<Rak>();
            listrakR = new List<Rak>(); 

        }

        public void getallisiRak() {
            ConnectDB databaseconnection = new ConnectDB();
            MySqlCommand myCommand = (MySqlCommand)databaseconnection.connection.CreateCommand();
            myCommand.CommandText = "SELECT * FROM `rak` ;";
            databaseconnection.OpenConnection();
            MySqlDataReader reader = myCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.GetString(0)[0] == 'L')
                    {
                        listrak.Add(new Rak(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2)));
                    }
                    else if (reader.GetString(0)[0] == 'R') {
                        listrakR.Add(new Rak(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2)));
                    }
                }
            }
            finally
            {
                reader.Close();
                databaseconnection.CloseConnection();
            }
        }

        public int countallisirak() {
            int jlh = 0;
            ConnectDB databaseconnection = new ConnectDB();
            MySqlCommand myCommand = (MySqlCommand)databaseconnection.connection.CreateCommand();
            myCommand.CommandText = "SELECT * FROM `rak` ;";
            databaseconnection.OpenConnection();
            MySqlDataReader reader = myCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(1) != 0)
                    {
                        jlh++; 
                    }
                }
            }
            finally
            {
                reader.Close();
                databaseconnection.CloseConnection();
            }

            return jlh;
        }
 

    }

    
}

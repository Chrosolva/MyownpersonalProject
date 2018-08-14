using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace Login
{
    class Rokok
    {
        public int Id_rokok { private set; get; } 
        public string Nama_rokok { private set; get; }
        public List<Rokok> lstrokok; 

        public Rokok() {
            this.Id_rokok = 0;
            this.Nama_rokok = "";
            this.lstrokok = new List<Rokok>(); 
        }

        public Rokok(int id, string nama) {
            this.Id_rokok = id;
            this.Nama_rokok = nama; 
        }

        public void getAllrokok() {
            ConnectDB databaseconnection = new ConnectDB();
            MySqlCommand myCommand = (MySqlCommand)databaseconnection.connection.CreateCommand();
            myCommand.CommandText = "SELECT * FROM rokok";
            databaseconnection.OpenConnection();
            MySqlDataReader reader = myCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    lstrokok.Add(new Rokok(reader.GetInt32(0), reader.GetString(1)));
                }
            }
            finally
            {
                reader.Close();
                databaseconnection.CloseConnection();
            }
        }

        public int getLatestID() {
            int hasil = 0;
            for (int i = 0; i < lstrokok.Count; i++) {
                if (lstrokok[i].Id_rokok > hasil) {
                    hasil = lstrokok[i].Id_rokok;
                }
            }
            return hasil+1;
        }

    }
}

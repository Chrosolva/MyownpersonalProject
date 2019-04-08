using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 


namespace Login
{
    class DetailBahan
    {
        public List<Bahan> lstbhn;


        public DetailBahan() {
            lstbhn = new List<Bahan>();
        }

        public void getAllBahan() {
            ConnectDB databaseconnection = new ConnectDB();
            SqlCommand myCommand = (SqlCommand)databaseconnection.connection.CreateCommand();
            myCommand.CommandText = "SELECT * FROM bahan ;";
            databaseconnection.OpenConnection();
            SqlDataReader reader = myCommand.ExecuteReader();
            try {
                while (reader.Read()) {
                    lstbhn.Add(new Bahan(reader.GetInt32(0), reader.GetString(1), reader.GetChar(2)));
                }
            }
            finally {
                reader.Close();
                databaseconnection.CloseConnection(); 
            }
        } 
    }
}

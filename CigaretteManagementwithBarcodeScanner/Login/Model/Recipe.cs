using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Login
{
    class Recipe
    {
        public int Id_rokok { private set; get; }
        public string nama_resep { private set; get; }
        public string nama_rokok { private set; get; } 
        public string nama_bahan { private set; get; }
        public int ID_bahan { private set; get; }
        public char grade { private set; get; }
        public List<Bahan> listbahan { private set; get; } 
        public List<string> listnamaresep { private set; get; }
        public Recipe() {
            this.Id_rokok = 0;
            this.nama_resep = "";
            this.nama_rokok = "";
            this.listbahan = new List<Bahan>();
            this.listnamaresep = new List<string>(); 
        }

        public Recipe(string namaresep, DetailBahan bhnursp, Rokok rkkursp) {
            this.nama_resep = namaresep;
            this.listbahan = bhnursp.lstbhn; 
            this.Id_rokok = rkkursp.Id_rokok;
            this.nama_rokok = rkkursp.Nama_rokok;
        }

        

        public void CreateRecipe() {
            ConnectDB databaseconnection = new ConnectDB();
            for (int i=0; i< this.listbahan.Count;i++) {
                string query = "Insert into resep (ID_Rokok,ID_Bahan,nama_resep,Nama_Bahan,Nama_Rokok,Grade) values (" + this.Id_rokok + "," + this.listbahan[i].ID_Bahan + ",'" + this.nama_resep + "','" + this.listbahan[i].Nama_Bahan.ToString() + "','" + this.nama_rokok + "','"+this.listbahan[i].Grade+"')";
                databaseconnection.Insert(query);
            }
        }

        public List<string> getAllRecipeName() {
            ConnectDB databaseconnection = new ConnectDB();
            SqlCommand myCommand = (SqlCommand)databaseconnection.connection.CreateCommand();
            myCommand.CommandText = "SELECT * FROM resep";
            databaseconnection.OpenConnection();
            SqlDataReader reader = myCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    listnamaresep.Add(reader.GetString(2)); 
                }
            }
            finally
            {
                reader.Close();
                databaseconnection.CloseConnection();
            }

            return listnamaresep;
        }

        public bool Checkrecipe(string namaresep) {
            List<string> tmp = new List<string>();
            tmp = this.getAllRecipeName(); 
             
            foreach (string x in tmp ) {
                if (namaresep.ToLower() == x.ToLower())
                {
                    return true;
                }
                else return false; 
            }
            return false; 
        }
    }
}

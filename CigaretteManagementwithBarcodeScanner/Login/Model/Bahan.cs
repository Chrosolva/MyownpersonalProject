using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Bahan
    {
        public int ID_Bahan { private set; get; } 
        public string Nama_Bahan { private set; get; } 
        public char Grade { private set; get; }

        public Bahan() {
            this.ID_Bahan = 0;
            this.Nama_Bahan = "";
            this.Grade = 'A'; 
        }

        public Bahan(int id, string nama, char grade ) {
            this.ID_Bahan = id;
            this.Nama_Bahan = nama;
            this.Grade = grade; 
        }

        public string InsertBahan() {
            return "INSERT INTO bahan (bahan.ID_Bahan,bahan.Nama_Bahan,bahan.Grade) VALUES (" + this.ID_Bahan + ",'" + this.Nama_Bahan + "','" + this.Grade.ToString() + "');"; 
        }

        public string updateBahan(int idbahan, string namabahan, char grade) {
            return "UPDATE bahan SET bahan.Nama_Bahan='" + namabahan + "' WHERE bahan.ID_Rak=" + idbahan.ToString() + ";";
        }
    }
}

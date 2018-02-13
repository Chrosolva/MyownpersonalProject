using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Bahan
    {
        public int IDbahan { private set; get; }
        public string namabahan { private set; get; }

        public Bahan( string nama) {
            this.namabahan = nama; 
        }
        public Bahan(int idbahan) {
            this.IDbahan = idbahan; 
        }
        public Bahan(int idbahan, string nama) {
            this.IDbahan = idbahan;
            this.namabahan = nama; 
        }

        public string insertBahan() {
            return "INSERT INTO `bahan` (`bahan`.`Nama_Bahan`) VALUES ('"+ this.namabahan + "');";
        }

        public string updatebahan(int idbahan, string nama_bahan) {
            return "UPDATE `bahan` SET `bahan`.`Nama_Bahan`='" + nama_bahan + "' WHERE `bahan`.`ID_Rak`=" + idbahan.ToString() + ";";
        }

        public string deletebahan(int idbahan) {
            return "DELETE FROM `bahan` WHERE `bahan`.`ID_Bahan`=" + idbahan.ToString() + ";";
        }
    }
}

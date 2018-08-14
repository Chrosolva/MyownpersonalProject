using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class rak
    {
        public string ID_rak { private set; get; } 
        public int ID_Bahan { private set; get; } 
        public string Nama_Bahan { private set; get; }
        public DateTime TanggalMasuk { private set; get; }

        public rak(string idrak, int idbahan, string namabahan, DateTime tgl) {
            this.ID_Bahan = idbahan;
            this.ID_rak = idrak;
            this.Nama_Bahan = namabahan;
            this.TanggalMasuk = tgl; 
        }

        public rak( int idbahan, string namabahan, DateTime tgl)
        {
            this.ID_Bahan = idbahan;
            this.Nama_Bahan = namabahan;
            this.TanggalMasuk = tgl;
        }

        public string InsertintoDrawer(string ID_Rak, Bahan bahan) {
            return "UPDATE `rak` SET `rak`.`ID_Bahan` = "+bahan.IDbahan.ToString()+" ,`rak`.`Nama_Bahan` = '"+bahan.namabahan+"' ,`rak`.`Tanggal_Masuk` = '" +(DateTime.Today.Date.ToString())+"' WHERE `rak`.`ID_Rak` = '"+ID_Rak+"';"; 
        } 



    }
}

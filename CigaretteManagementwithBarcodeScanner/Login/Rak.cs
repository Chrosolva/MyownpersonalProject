using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Rak
    {
        public string ID_rak { private set; get; }
        public int ID_Bahan { private set; get; }
        public DateTime TanggalMasuk { private set; get; }

        public Rak() {
            this.ID_Bahan = 0;
            this.ID_rak = "";
            this.TanggalMasuk = DateTime.Today.Date;
        }

        public Rak(string idrak, int idbahan,  DateTime tgl)
        {
            this.ID_Bahan = idbahan;
            this.ID_rak = idrak;
            this.TanggalMasuk = tgl;
        }

        public Rak(int idbahan,  DateTime tgl)
        {
            this.ID_Bahan = idbahan;
            this.TanggalMasuk = tgl;
        }

        public string InsertintoDrawer(string ID_Rak, Bahan bahan)
        {
            return "UPDATE `rak` SET `rak`.`ID_Bahan` = " + bahan.ID_Bahan.ToString() +  " ,`rak`.`Tanggal_Masuk` = '" + this.settanggal() + "' WHERE `rak`.`ID_Rak` = '" + ID_Rak + "';";
        }

        public void setIDrak(Rak x) {
            this.ID_rak = x.ID_rak; 
        }

        public void setIDBahan(Rak x)
        {
            this.ID_Bahan = x.ID_Bahan;
        }

        public string settanggal()
        {
            string tgl = "";
            tgl+=this.TanggalMasuk.Year.ToString();
            if (this.TanggalMasuk.Month < 10) {
                tgl += "0" + this.TanggalMasuk.Month.ToString();
            }
            else {
                tgl += this.TanggalMasuk.ToString(); 
            }

            if (this.TanggalMasuk.Day < 10) {
                tgl += "0" + this.TanggalMasuk.Day.ToString();
            }
            else {
                    tgl += this.TanggalMasuk.Day.ToString();
            }
            return tgl;
        }
    }
}

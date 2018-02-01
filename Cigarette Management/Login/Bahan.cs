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

        public Bahan(int id, string nama) {
            this.IDbahan = id;
            this.namabahan = nama; 
        } 


    }
}

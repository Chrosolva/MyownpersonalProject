using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data; 

namespace Login.Controller
{
    public class ControllerSendLocation
    {
        private ConnectDB objConnection; 
        List<Tuple<string, string,string>> listnamabahan ;
        public List<string> listidrak;
        public DataTable dt; 

        public ControllerSendLocation()
        {
            listnamabahan = new List<Tuple<string, string,string>>();
            listidrak = new List<string>();
            objConnection = new ConnectDB(); 
        } 

        public ControllerSendLocation(DataTable dtforing)
        {
            listnamabahan = new List<Tuple<string, string, string>>();
            listidrak = new List<string>();
            objConnection = new ConnectDB();
            listnamabahan.Clear(); 
            foreach (DataRow x in dtforing.Rows)
            {
                listnamabahan.Add(new Tuple<string, string,string>(x["ID_Bahan"].ToString(),x["Nama_Bahan"].ToString(), x["Grade"].ToString())); 
            } 
        } 

        public List<string> getAllDrawerLocation()
        {
            foreach (Tuple<string,string, string> x in listnamabahan)
            {
                string query = "Select top 1 ID_Rak from rak where ID_Bahan = '" + x.Item1.ToString() +"' order by Tanggal_Masuk Asc;" ;
                dt = new DataTable(); 
                dt = objConnection.FillDataTable(query);
                listidrak.Add(dt.Rows[0][0].ToString()); 
            }
            return this.listidrak; 
        } 

        public bool checkstock()
        {
            foreach(Tuple<string, string, string> x in listnamabahan)
            {
                string query = "Select top 1 ID_Rak from Rak where ID_Bahan = '" + x.Item1.ToString() + "' order by Tanggal_Masuk Asc;";
                dt = objConnection.FillDataTable(query);
                if (dt==null)
                {
                    return false;
                }
                else
                {
                    continue; 
                }
            }
            return true;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Timers;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Login.Controller;
using System.Threading;

namespace Login
{
    public partial class SendLocation : Form
    {
        public string namaresep = ""; 
        public string Dataout ="+";
        public string Dataint;
        public bool next = false;
        private DataTable dt;
        private DataTable dtforing; 
        public ConnectDB objConnection = new ConnectDB();
        private ControllerSendLocation objSendLocation ;
        private List<string> listsent = new List<string>();
        private System.Object SerialIncoming;
        public int count =0;
        
        public SendLocation()
        {
            InitializeComponent();
            fillcbresep();
            SerialIncoming = new object(); 

        } 

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #region methods

        public void fillcbresep()
        {
            try
            {
                string query = "Select Distinct nama_resep from Resep;";
                dt = objConnection.FillDataTable(query);

                foreach (DataRow x in dt.Rows)
                {
                    cbxSelectedRecipe.Items.Add(x["nama_resep"].ToString());
                }
            }

            catch (Exception e)
            {
                throw e;
            }

        }


        public void FillDGview(string namaresep)
        {
            try
            {
                string query = "Select ID_Bahan,Nama_Bahan, Grade from Resep where nama_resep = '" + namaresep + "';";
                dtforing = objConnection.FillDataTable(query);
                DgvforSent.DataSource = dtforing;
                
            }

            catch (Exception e)
            {
                throw e; 
            }
        }

        #endregion

        private void cbxSelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGview(cbxSelectedRecipe.SelectedItem.ToString()); 
            
        }

        private void SendLocation_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(port); 
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.NewLine = "\n";

                serialPort1.Open();
                progressBar1.Value = 100;
                //serialPort1.DataReceived += Proxy;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSendData.Enabled = true;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
            btnSendData.Enabled = false; 
        }

        private void Proxy(Object unused1, SerialDataReceivedEventArgs unused2)
        {
            MessageBox.Show("Data Received");
            lock (serialPort1)
            {
                Monitor.Pulse(serialPort1); 
            }
        }

        public bool WaitForAData(int Timeout)
        {
            lock (serialPort1)
            {
                if(!Monitor.Wait(serialPort1,Timeout))
                {
                    MessageBox.Show("Timeout");
                    return false;
                }
                return true; 
            }
        }

        

        private void btnSendData_Click(object sender, EventArgs e)
        {
            Thread loopthread = new Thread(new ParameterizedThreadStart(sendData));
            objSendLocation = new ControllerSendLocation(dtforing);
            if (objSendLocation.checkstock() == false)
            {
                MessageBox.Show("Stock ada yang kosong");
            }
            else
            {
                listsent.Clear();
                listsent = objSendLocation.getAllDrawerLocation();
                timerSL.Enabled = true;
                timerSL.Start();
                loopthread.Start(listsent);
                
            }
            
        }

        public void InvokeTextbox(object sender, EventArgs e, string x) {
            txtBoxDataOut.Text += x + "\n";
        }

        public void InvokeTextboxdatain(object sender, EventArgs e, string x)
        {
            txtBoxDatain.Text += x + "\n";
        }

        public void sendData(object listsent)
        {
            foreach (string x in (List<string>)listsent)
            {
                Dataout = "*" + x + "#";
                serialPort1.WriteLine(Dataout);
                Invoke(new EventHandler((sender, e) => InvokeTextbox(sender, e, Dataout)));
                if (next == false)
                {
                    do
                    {
                        string tempnext = serialPort1.ReadLine();
                        if (tempnext.ToUpper().ToString().Contains("OK"))
                        {
                            next = true;
                            break;
                        }
                        else if (!tempnext.ToUpper().ToString().Contains("OK"))
                        {
                            //serialPort1.WriteLine(Dataout);
                            //Invoke(new EventHandler((sender, e) => InvokeTextbox(sender, e, Dataout)));
                            next = false;
                        }
                    }
                    while (next != true);
                }
                next = false;
            }
            timerSL.Stop();
            count = 0;

        }

        //private void resenddata( string x)
        //{
        //    serialPort1.WriteLine(x);
        //    Invoke(new EventHandler((sender, e) => InvokeTextbox(sender, e, x)));
        //}

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Dataint = serialPort1.ReadLine();
            Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            txtBoxDatain.Text += Dataint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void timerSL_Tick(object sender, EventArgs e)
        {   
            serialPort1.WriteLine(Dataout);
            Invoke(new EventHandler((s, ev) => InvokeTextbox(s, ev, Dataout)));
        }
    }
}

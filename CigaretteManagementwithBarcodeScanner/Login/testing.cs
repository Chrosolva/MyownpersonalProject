using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; 
namespace Login
{
    public partial class testing : Form
    {
        string dataOut;
        string dataIn; 
        public testing()
        {
            InitializeComponent();
            

        }

       

        private void testing_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(port); 

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBuildRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity) , cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100; 
            }

            catch (Exception err) {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) {
                serialPort1.Close();
                progressBar1.Value = 0; 
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) {
                dataOut = txtBoxDataOut.Text;
                serialPort1.WriteLine(dataOut); 
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }
    }
}

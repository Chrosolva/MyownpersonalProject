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
    public partial class SendLocation : Form
    {
        public string Dataout;
        public string Dataint; 
        public SendLocation()
        {
            InitializeComponent();
        }
    }
}

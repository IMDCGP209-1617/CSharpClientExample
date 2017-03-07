using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpClient
{
    public partial class ConnectDialog : Form
    {
        public ConnectDialog()
        {
            InitializeComponent();
        }

        public bool GetAddress(out IPAddress ip, out int port)
        {
            var ipAddress = ipAddressText.Text;
            var validPort = int.TryParse(portText.Text, out port);
            return IPAddress.TryParse(ipAddress, out ip) && validPort;
        }
    }
}

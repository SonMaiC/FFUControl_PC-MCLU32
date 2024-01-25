using System.Net;
using System.Net.Sockets;

namespace FFU_Fan_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Fields
        private TcpClient tcpClient;
        private NetworkStream ns;
        private string iP = "192.168.124.1";
        private int port = 0x9005;

        #endregion

    }
}
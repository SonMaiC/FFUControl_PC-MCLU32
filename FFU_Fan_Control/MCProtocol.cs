using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FFU_Fan_Control
{
    public class Melsec
    {
        public enum DeviceType : byte
        {
            M = 0x90,
            L = 0x92,
            D = 0xA8,
            ZR = 0xB0,
        }

        #region Fields
        private TcpClient tcpClient;
        private NetworkStream ns;
        private int port;
        private string ip;

        #endregion

    }
}

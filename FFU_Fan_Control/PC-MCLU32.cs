using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FFU_Fan_Control
{
    public class PC_MCLU32
    {
        #region Constructor
        public PC_MCLU32(string portName)
        {
            sp.PortName = portName;
            sp.BaudRate = 9600;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.DataBits = 8;
            sp.Encoding = Encoding.GetEncoding(28591);
            sp.ReadTimeout = 1000;
        }
        #endregion

        #region Fields
        private SerialPort sp = new SerialPort();
        public bool IsConnected = false;
        #endregion

        private enum Mode1
        {
            GroupRead = 0x8E,
            GroupWrite = 0x8D,
            BlockRead = 0x8A,
            BlockWrite = 0x89,
            Reset = 0x99
        }
        private enum Mode2
        {
            GroupRead = 0x83,
            GroupWrite = 0x9F,
            BlockRead = 0x9F,
            BlockWrite = 0xBF,
            Reset = 0xBF
        }

        public void Connect()
        {
            if (sp.IsOpen) return;

            try
            {
                sp.Open();
                if(sp.IsOpen) { IsConnected = true; } 
            }
            catch (Exception)
            {
                IsConnected = false;
            }
        }

        public void Disconnect() 
        {
            if (!sp.IsOpen) return;
            sp.Close();
        }

        public bool GroupWrite(int nMCULID,int nLCUID,int nSpeed)
        {
            if(!sp.IsOpen) return false;


            return true;
        }

        public bool Write() 
        {
            return true;
        }

        public void GroupRead(ref int[] nSpeed,ref int[] nStatus)
        {
            
        }
    }
}

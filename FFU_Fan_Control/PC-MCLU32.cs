using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Http.Headers;
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

        /// <summary>
        /// Lower speed limit value 0~1000rpm
        /// </summary>
        private int dataLSV = 0x00;
        public int DataLSV
        {
            get { return dataLSV; }
            set
            {
                if (value < dataHSV) dataLSV = dataHSV;
                if (value < 0) dataLSV = 0;
                dataLSV = value / 10;
            }
        }
        /// <summary>
        /// Higher speed limit value 0~1000rpm
        /// </summary>
        private int dataHSV;
        public int DataHSV
        {
            get { return dataHSV; }
            set
            {
                if (value < dataLSV) dataHSV = dataLSV;
                if (value > 1000) dataHSV = 1000 /10;
                dataHSV = value /10;
            }
        }
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
        public bool GroupWrite(int nSpeed)
        {
            return GroupWrite(1, nSpeed);
        }
        public bool GroupWrite(int nMCULID,int nSpeed)
        {
            if(!sp.IsOpen) return false;
            if(nMCULID <= 0 || nMCULID > 32) return false;

            int mculID = nMCULID - 1;
            byte[] gram = new byte[10];
            int dataSV = (nSpeed / 10);
            byte checksum = 0;

            gram[0] = 0x02;
            gram[1] = (byte)Mode1.GroupWrite;
            gram[2] = (byte)Mode2.GroupWrite;
            gram[3] = (byte)(0x81 + mculID);
            gram[4] = 0x9F;
            gram[5] = (byte)dataSV;
            gram[6] = (byte)dataLSV;
            gram[7] = (byte)dataHSV;
            gram[9] = 0x03;
            for (int i = 1; i < 8; i++)
            {
                checksum += gram[i];
            }
            gram[8] = checksum;

            try
            {
                sp.Write(gram, 0, gram.Length);
                byte[] resByte = new byte[sp.BytesToRead];
                int length = sp.Read(resByte, 0, sp.BytesToRead);
                if (length <= 0) return false;
                if (resByte[1] == (byte)Mode1.GroupWrite &&
                    resByte[2] == (byte)Mode2.GroupWrite &&
                    resByte[3] == (byte)(0x81 + mculID) &&
                    resByte[5] == 0xB9)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool BlockWrite(int nLCUID, int nSpeed)
        {
            return BlockWrite(1, nLCUID, nSpeed);
        }
        public bool BlockWrite(int nMCULID, int nLCUID, int nSpeed)
        {
            if (!sp.IsOpen) return false;
            if (nMCULID <= 0 || nMCULID > 32) return false;
            if (nLCUID <= 0 || nLCUID > 32) return false;

            int mculID = nMCULID - 1;
            int lcuID = nLCUID - 1;
            byte[] gram = new byte[12];
            int dataSV = (nSpeed / 10);
            byte checksum = 0;

            gram[0] = 0x02;
            gram[1] = (byte)Mode1.BlockWrite;
            gram[2] = (byte)Mode2.BlockWrite;
            gram[3] = (byte)(0x81 + mculID);
            gram[4] = 0x9F;
            gram[5] = (byte)(0x81 + lcuID);
            gram[6] = (byte)(0x81 + lcuID);
            gram[7] = (byte)dataSV;
            gram[8] = (byte)dataLSV;
            gram[9] = (byte)dataHSV;
            gram[11] = 0x03;
            for (int i = 1; i < 10; i++)
            {
                checksum += gram[i];
            }
            gram[10] = checksum;

            try
            {
                sp.Write(gram, 0, gram.Length);
                byte[] resByte = new byte[sp.BytesToRead];
                int length = sp.Read(resByte, 0, sp.BytesToRead);
                if (length <= 0) return false;
                if (resByte[1] == (byte)Mode1.GroupWrite &&
                    resByte[2] == (byte)Mode2.GroupWrite &&
                    resByte[3] == (byte)(0x81 + mculID) &&
                    resByte[5] == 0xB9)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool GroupRead(ref int[] nSpeed, ref int[] nStatus)
        {
          return GroupRead(1,ref nSpeed,ref nStatus);
        }
        public bool GroupRead(int nMCULID,ref int[] nSpeed,ref int[] nStatus)
        {
            if (!sp.IsOpen) return false;
            if (nMCULID <= 0 || nMCULID > 32) return false;

            int mculID = nMCULID - 1;
            byte[] gram = new byte[7];
            byte checksum = 0;


            gram[0] = 0x02;
            gram[1] = (byte)Mode1.GroupRead;
            gram[2] = (byte)Mode2.GroupRead;
            gram[3] = (byte)(0x081 + mculID);
            gram[4] = 0x9F;
            gram[6] = 0x03;
            for (int i = 1; i < 5; i++)
            {
                checksum += gram[i];
            }
            gram[5] = checksum;

            try
            {
                sp.Write(gram, 0, gram.Length);
                byte[] resByte = new byte[sp.BytesToRead];
                int length = sp.Read(resByte, 0, sp.BytesToRead);
                if (length <= 0) return false;
                if (resByte[1] == (byte)Mode1.GroupWrite &&
                    resByte[2] == (byte)Mode2.GroupWrite &&
                    resByte[3] == (byte)(0x81 + mculID))
                {

                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

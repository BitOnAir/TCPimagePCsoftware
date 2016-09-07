using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

using System.Text;

namespace DSPprogrammer_Ethernet
{
    partial class Form1 : Form
    {
        /********************************** UDP receive thread *************************************/
        string receiveStringIP;
        bool isStartUDPrx = false;
        bool isGetDspIP = false;
        //IPAddress[] dspIPlist;
        public void udp_rx_fun()
        {
            while (true)
            {
                if (!isStartUDPrx && !tcpClientD.Connected)
                {
                    UdpState s = new UdpState();
                    s.e = hostEnd;
                    s.u = udpHost;
                    udpHost.BeginReceive(new AsyncCallback(ReceiveCallback), s);
                    isStartUDPrx = true;
                }
            }
        }

        public void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)((UdpState)(ar.AsyncState)).u;
            IPEndPoint e = (IPEndPoint)((UdpState)(ar.AsyncState)).e;
            int i = 0;
            Byte[] receiveBytes = u.EndReceive(ar, ref e);
            if ((receiveBytes[0] == (byte)'I') && (receiveBytes[1] == (byte)'P'))
            {
                System.Array.Reverse(receiveBytes);
                i = System.Array.IndexOf(receiveBytes, (byte)46);

                receiveStringIP = Encoding.ASCII.GetString(receiveBytes, i + 1, receiveBytes.Length - i - 3);

                if (!cmbBoxIP.Items.Contains(receiveStringIP))
                {
                    printInfo(receiveStringIP, trx_type.RX);
                    AddItem(receiveStringIP);
                }

                isStartUDPrx = false;
                isGetDspIP = true;
            }
            //isStartUDPrx = false;
        }

        /********************************** TCP tranceiver thread *********************************/
        bool hasTxData = false;
        int SendingSize = 0;
        private Byte[] tcpTxBuffer = new Byte[1024];
        public void tcp_tx_fun()
        {
            while (true)
            {
                if (tcpClientD.Connected && hasTxData)
                {
                    int len = 0;
                    len = tcpClientD.Client.Send(tcpTxBuffer, SendingSize, SocketFlags.None);
                    hasTxData = false;
                }
            }
        }
    }
}

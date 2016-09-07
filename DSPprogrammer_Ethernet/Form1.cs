using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

using System.Threading;
using System.Runtime.InteropServices;

namespace DSPprogrammer_Ethernet
{
    public partial class Form1 : Form
    {
        private Thread TcpTxThread;
        private Thread UdpRxThread;
        TcpClient tcpClientD = new TcpClient(AddressFamily.InterNetwork);

        UdpClient udpHost = null;
        IPEndPoint hostEnd = null;

        dataFrameType downLinkFrm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxView.Text = "WELCOME! Version: 0.0.1-----YuanQi vision\r\n";
            
            IPHostEntry ipe = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress hostIP = null;

            /**************** Get local host IP address ********************/
            foreach (IPAddress hostIPtmp in ipe.AddressList)
            {
                if (hostIPtmp.AddressFamily == AddressFamily.InterNetwork)
                {
                    hostIP = hostIPtmp;
                }
            }

            hostEnd = new IPEndPoint(hostIP, 2315);
            //Socket udpRx = new Socket(hostEnd.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            //udpRx.Bind(hostEnd);
            udpHost = new UdpClient(hostEnd);
            printInfo("Local UDP:"+hostEnd.ToString(), trx_type.NX);

            UdpRxThread = new Thread(new ThreadStart(udp_rx_fun));
            UdpRxThread.Start();

            TcpTxThread = new Thread(new ThreadStart(tcp_tx_fun));
            TcpTxThread.Start();

            downLinkFrm.frameHead = 0x43;
            downLinkFrm.frameTail = 0x52;
        }


        enum trx_type{TX, RX, NX};
        private void printInfo(string str, trx_type txrx_mode)
        {
            SetText(DateTime.Now.ToString("HH:mm:ss:fff") + "|");
            if (txrx_mode == trx_type.TX)
            {
                SetText(">>> ");
            }
            else if (txrx_mode == trx_type.RX)
            {
                SetText("<<< ");
            }
            else
            {
                SetText(": ");
            }
            SetText(str + "\r\n");
        }

        /**
         * Generate update.ais file 
         */
        String aisFileName, testChk;
        Byte[] tpBuf = new Byte[512];
        private void btnFileBrs_Click(object sender, EventArgs e)
        {
            String fileName, cpPath, toolPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                cpPath = Environment.CurrentDirectory+"\\Tools\\"+openFileDialog1.SafeFileName;
                toolPath = Environment.CurrentDirectory + "\\Tools\\genAIS.bat";
                txtBoxView.AppendText("\r\nReading file......\r\n");
                File.Copy(fileName, cpPath,true);

                testChk = openFileDialog1.FileName;

                MemoryStream tempFs = new MemoryStream(512);
                // Open the stream and read it back.
                using (FileStream fs = File.Open(toolPath, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.CopyTo(tempFs);
                }

                using (FileStream fs2 = File.Create(toolPath))
                {
                    int i;
                    Byte[] srcFileName = System.Text.Encoding.Default.GetBytes(openFileDialog1.SafeFileName + " -o ");
                    Byte[] dstFileName = System.Text.Encoding.Default.GetBytes(openFileDialog1.SafeFileName.Remove(openFileDialog1.SafeFileName.IndexOf("."))+" ");
                    
                    tempFs.Seek(0, SeekOrigin.Begin);
                    tempFs.Read(tpBuf, 0, 13);
                    fs2.Write(tpBuf, 0, 13);
                    fs2.Write(srcFileName, 0, srcFileName.Length);
                    fs2.Write(dstFileName, 0, dstFileName.Length);

                    tpBuf = tempFs.ToArray();
                    for (i = 0; i < tpBuf.Length; i++)
                    {
                        if ((tpBuf[i] == '-') && (tpBuf[i + 1] == 'c') && (tpBuf[i + 2] == 'f') && (tpBuf[i + 3] == 'g'))
                        {
                            break;
                        }
                    }
                    tempFs.Seek(i, SeekOrigin.Begin);
                    tempFs.CopyTo(fs2);
                }
                
                //start .bat file
                Process pro = new Process();

                FileInfo file = new FileInfo(toolPath);
                pro.StartInfo.WorkingDirectory = file.Directory.FullName;
                pro.StartInfo.FileName = toolPath;
                pro.StartInfo.CreateNoWindow = false;
                pro.Start();
                pro.WaitForExit();

                //delete src.out file
                aisFileName = openFileDialog1.SafeFileName.Remove(openFileDialog1.SafeFileName.IndexOf(".")) + ".ais";

                FileInfo fais = new FileInfo(aisFileName);
                if (!fais.Exists)
                {
                    txtBoxView.AppendText("make .ais file failed!\r\n");
                }
                else
                {
                    txtBoxView.AppendText("make .ais file success!\r\n");
                }

            }
        }

        /**
         * Use the textBoxView/ComboBox in other thread
         */
        delegate void SetTextCallBack(string text);
        private void SetText(string text)
        {
            if (this.txtBoxView.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(SetText);
                this.Invoke(stcb, new object[] { text });
            }
            else
            {
                this.txtBoxView.AppendText(text);
            }
        }

        delegate void AddItemsCallBack(string text);
        private void AddItem(string text)
        {
            if (this.txtBoxView.InvokeRequired)
            {
                AddItemsCallBack aicb = new AddItemsCallBack(AddItem);
                this.Invoke(aicb, new object[] { text });
            }
            else
            {
                cmbBoxIP.Items.Add(text);
            }
        }

        /**
         * Asynchronous receive image pixel data.
         */
        private Byte[] tcpRxBuffer = new Byte[1280 * 1024];
        private int totalBytes = 0;
        public void TCP_Read_Callback(IAsyncResult ar)
        {
            int read =tcpClientD.Client.EndReceive(ar);
            totalBytes += read;
            if (read > 0)
            {
                if (totalBytes > (640 * 480))
                {
                    if (tcpRxBuffer[0] == 0x10)
                    {
                        Int32 imgWidth = tcpRxBuffer[1] + ((Int32)tcpRxBuffer[2] << 8) + ((Int32)tcpRxBuffer[3] << 16) + ((Int32)tcpRxBuffer[4] << 24);
                        Int32 imgheight = tcpRxBuffer[5] + ((Int32)tcpRxBuffer[6] << 8) + ((Int32)tcpRxBuffer[7] << 16) + ((Int32)tcpRxBuffer[8] << 24);

                        Byte[] imgBuffer = new Byte[imgWidth * imgheight];
                        Bitmap dspBitmap = new Bitmap(imgWidth, imgheight, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
                        Rectangle rect = new Rectangle(0, 0, imgWidth, imgheight);
                        System.Drawing.Imaging.BitmapData bmpData = dspBitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, dspBitmap.PixelFormat);
                        IntPtr ptr = bmpData.Scan0;

                        System.Runtime.InteropServices.Marshal.Copy(ptr, imgBuffer, 0, imgWidth * imgheight);
                        Array.Copy(tcpRxBuffer, 9, imgBuffer, 0, imgWidth * imgheight);
                        // Copy the RGB values back to the bitmap
                        System.Runtime.InteropServices.Marshal.Copy(imgBuffer, 0, ptr, imgWidth * imgheight);
                        dspBitmap.UnlockBits(bmpData);

                        // 修改生成位图的索引表，从伪彩修改为灰度  
                        System.Drawing.Imaging.ColorPalette palette;
                        // 获取一个Format8bppIndexed格式图像的Palette对象  
                        using (Bitmap bmp = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format8bppIndexed))
                        {
                            palette = bmp.Palette;
                        }
                        for (int i = 0; i < 256; i++)
                        {
                            palette.Entries[i] = Color.FromArgb(i, i, i);
                        }
                        // 修改生成位图的索引表  
                        dspBitmap.Palette = palette;

                        pictureBox1.Image = dspBitmap;
                        totalBytes = 0;
                    }
                    else
                    {
                        totalBytes = 0;

                    }
                }

                //str = System.Text.Encoding.Default.GetString(tpBuf, 0, byteSize);
                tcpClientD.Client.BeginReceive(tcpRxBuffer, totalBytes, tcpRxBuffer.Length-totalBytes, 0, new AsyncCallback(TCP_Read_Callback), null);
            }
            else
            {
                tcpClientD.Client.Disconnect(true);
                printInfo("Disconnected!", trx_type.NX);
            }
        }

        /************************** connect button ************************************/
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (tcpClientD.Connected)
            {
                tcpClientD.Client.Disconnect(true);
            }
            if (!isGetDspIP)
            {
                printInfo("Do not get DSP IP address!", trx_type.NX);
            }
            else
            {
                printInfo("Connect to " + receiveStringIP, trx_type.NX);
                tcpClientD.SendBufferSize = 8 * 1024;
                tcpClientD.ReceiveBufferSize = 8 * 1024;
                tcpClientD.SendTimeout = 1000;
                tcpClientD.BeginConnect(System.Net.IPAddress.Parse(cmbBoxIP.SelectedItem.ToString()), 2314, new AsyncCallback(ConnectCallback), null);
            }
        }
        public void ConnectCallback(IAsyncResult ar)
        {
            printInfo("DSP is connected!", trx_type.NX);
            tcpClientD.EndConnect(ar);
            if (tcpClientD.Connected)
            {
                tcpClientD.Client.BeginReceive(tcpRxBuffer, 0, tcpRxBuffer.Length, 0, new AsyncCallback(TCP_Read_Callback), null);
            }
        }
        
        /**
         * ROI select
         */
        Rectangle rectMark = new Rectangle(0,0,0,0);
        bool rMouseDown = false;
        bool RoiMark = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            rectMark.X = e.X;
            rectMark.Y = e.Y;
            rMouseDown = true;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rMouseDown)
            {
                pictureBox1.Refresh();
                Graphics g = pictureBox1.CreateGraphics();
                Pen pen1 = new Pen(Color.Red);

                rectMark.Width = Math.Abs(e.X - rectMark.X) + 1;
                rectMark.Height = Math.Abs(e.Y - rectMark.Y) + 1;

                g.DrawRectangle(pen1, rectMark);
                g.Dispose();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            rMouseDown = false;
            RoiMark = true;
            printInfo("ROI:" + rectMark.ToString(), trx_type.NX);
        }

        

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] sendBuffer = new byte[500];
            string[] tmp_databuf = txtBoxSendData.Text.Split( new[] {" "},StringSplitOptions.RemoveEmptyEntries);
            byte[] tBytes = Array.ConvertAll(tmp_databuf, s => Convert.ToByte(s, 16));

            sendBuffer[0] = 0x43;
            sendBuffer[1] = (Byte)((tBytes.Length & 0x0000FF00) >> 8);
            sendBuffer[2] = (Byte)(tBytes.Length & 0x000000FF);

            Array.Copy(tBytes, 0, sendBuffer, 3, tBytes.Length);
            sendBuffer[tBytes.Length + 3] = 0x52;

            if (tcpClientD.Connected)
            {
                tcpClientD.Client.Send(sendBuffer, tBytes.Length + 4, SocketFlags.None);
            }
            else
            {
                printInfo("Connection doesn't setup", trx_type.NX);
            }
        }



    }

    public class UdpState : Object
    {
        public IPEndPoint e;
        public UdpClient u;
    }
}

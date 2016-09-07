using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSPprogrammer_Ethernet
{
    partial class Form1 : Form
    {
        /**
         * 相机管理命令
         */
        private void 连续触发模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x3000;
                downLinkFrm.load.cmdContent = new byte[1];
                downLinkFrm.load.cmdContent[0] = 0x01;

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;

                int i;
                string dataSend = "";
                for (i = 0; i < SendingSize; i++)
                {
                    string hexStr =  Convert.ToString(tcpTxBuffer[i], 16);
                    if (hexStr.Length == 1)
                    {
                        hexStr = "0" + hexStr;
                    }

                    dataSend += " " + hexStr;
                }
                printInfo(dataSend, trx_type.TX);
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }
        private void 软触发模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x3000;
                downLinkFrm.load.cmdContent = new byte[1];
                downLinkFrm.load.cmdContent[0] = 0x02;

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 硬触发模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x3000;
                downLinkFrm.load.cmdContent = new byte[1];
                downLinkFrm.load.cmdContent[0] = 0x03;

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 暂停采图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x3000;
                downLinkFrm.load.cmdContent = new byte[1];
                downLinkFrm.load.cmdContent[0] = 0x04;

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 配置相机参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 读取相机参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 升级相机程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询相机错误ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /**
         * 任务管理命令
         */
        private void 添加任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 更新任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 测试任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------//
        private void 清空任务列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x2101;
                downLinkFrm.load.cmdContent = new byte[0];

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 强制单步任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x2102;
                downLinkFrm.load.cmdContent = new byte[0];

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 取消强制单步ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x2103;
                downLinkFrm.load.cmdContent = new byte[0];

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 运行任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x2104;
                downLinkFrm.load.cmdContent = new byte[0];

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 停止任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x2105;
                downLinkFrm.load.cmdContent = new byte[0];

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 保存任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x2106;
                downLinkFrm.load.cmdContent = new byte[0];

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        private void 同步任务配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hasTxData)
            {
                downLinkFrm.load.cmdType = 0x2107;
                downLinkFrm.load.cmdContent = new byte[0];

                downLinkFrm.loadLength = (UInt16)(0x0002 + downLinkFrm.load.cmdContent.Length);

                fillTxBuffer(tcpTxBuffer);

                hasTxData = true;
            }
            else
            {
                printInfo("有命令待处理", trx_type.NX);
            }
        }

        public void fillTxBuffer(Byte[] tcpTxbuf)
        {
            int indexOfTxbuf = 0;

            //fill head
            tcpTxBuffer[0] = downLinkFrm.frameHead;
            indexOfTxbuf += 1;

            //fill load length
            byte[] loadlength = System.BitConverter.GetBytes(downLinkFrm.loadLength);
            Array.Copy(loadlength, 0, tcpTxBuffer, indexOfTxbuf, loadlength.Length);
            indexOfTxbuf += loadlength.Length;

            //fill load: command type, command's data
            byte[] cmdType = System.BitConverter.GetBytes(downLinkFrm.load.cmdType);
            Array.Copy(cmdType, 0, tcpTxBuffer, indexOfTxbuf, cmdType.Length);
            indexOfTxbuf += cmdType.Length;

            Array.Copy(downLinkFrm.load.cmdContent, 0, tcpTxBuffer, indexOfTxbuf, downLinkFrm.load.cmdContent.Length);
            indexOfTxbuf += downLinkFrm.load.cmdContent.Length;

            tcpTxBuffer[indexOfTxbuf] = downLinkFrm.frameTail;
            SendingSize = indexOfTxbuf + 1;
        }
    }
}

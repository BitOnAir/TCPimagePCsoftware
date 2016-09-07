using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


    
namespace DSPprogrammer_Ethernet
{
    public struct dataFrameType
    {
        public byte frameHead;
        public UInt16 loadLength;
        public cmdFrameType load;
        public byte frameTail;
    }

    public struct cmdFrameType
    {
        public UInt16 cmdType;
        public byte[] cmdContent;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace File_Compression_Engine
{
    internal class HuffmanNode
    {
        public byte? Byte {  get; set; }
        public int Frequency { get; set; }

        public HuffmanNode? Left { get; set; }
        public HuffmanNode? Right { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace File_Compression_Engine
{
    internal class HuffmanEncoder
    {
        private void TraverseTree(HuffmanNode? node, string currentCode, Dictionary<byte, string> codes)
        {
            if (node == null) {  return; }

            if (node.Left == null && node.Right == null)
            {
                codes[node.Byte.Value] = currentCode; 
                    
                return;
            }

            TraverseTree(node.Left, currentCode + "0", codes);

            TraverseTree(node.Right, currentCode + "1", codes);
        }

        public Dictionary<byte, string> GenerateCodes(HuffmanNode root)
        {
            Dictionary<byte, string> codes = new Dictionary<byte, string>();

            TraverseTree(root, "", codes);

            return codes;
        }
    }
}

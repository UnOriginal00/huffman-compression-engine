using System;
using System.Collections.Generic;
using System.Text;

namespace File_Compression_Engine
{
    internal class HuffmanTreeBuilder
    {
        public PriorityQueue<HuffmanNode,int> huffmanPriorityQueue = new PriorityQueue<HuffmanNode, int>();
        public HuffmanNode TreeBuilder(Dictionary<byte,int> sortedDictionary)
        {
            if (sortedDictionary.Count == 0)
            {
                return null;
            }

            foreach (var (bytes,frequency) in sortedDictionary) {

                HuffmanNode node = new HuffmanNode();
                node.Byte = bytes;
                node.Frequency = frequency;
                huffmanPriorityQueue.Enqueue(node,frequency);

            }

            while(huffmanPriorityQueue.Count > 1)
            {
                HuffmanNode leftNode = huffmanPriorityQueue.Dequeue();
                HuffmanNode? rightNode = huffmanPriorityQueue.Dequeue();
          
                HuffmanNode parentNode = new HuffmanNode();
                parentNode.Frequency = leftNode.Frequency + rightNode.Frequency;
                parentNode.Left = leftNode;
                parentNode.Right = rightNode;

                huffmanPriorityQueue.Enqueue(parentNode, parentNode.Frequency);
            }

            return huffmanPriorityQueue.Dequeue();

        }


    }
}

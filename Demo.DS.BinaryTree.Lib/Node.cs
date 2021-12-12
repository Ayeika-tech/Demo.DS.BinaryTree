using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DS.BinaryTree.Lib
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public int Data { get; private set; }

        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}

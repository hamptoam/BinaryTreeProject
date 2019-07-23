using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int integer;
        public int i;
        public Node leftNode;
        public Node rightNode;
        public Node root;

        public Node(int value)
        {
            integer = value;
            i = value;
            leftNode = null;
            rightNode = null;


        }
        public Node Add(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }

            else if (node.integer > data)
            {
                Add(root.leftNode, i);
            }
            else if (node.integer < data)
            {
                Add(root.rightNode, i);
            }

            return root;
        }
    }
}
    


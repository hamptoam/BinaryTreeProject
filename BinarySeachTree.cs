using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
   public class BinarySeachTree
    {
        public Node root;
        public int count;
        public int value;
        public int i; 


        public BinarySeachTree()
        {
            root = null;
            count = 0;
            value = 0;
            i = value; 
            
        }

        public Node Add(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }

            else if (node.value < data)
            {
                Add(node.rightNode, i);
            }

            else if (node.value > data)
            {
                Add(node.leftNode, i);
            }

            return root;
        }
           public Node Search(Node node, int data)
        {
                if (node == null)
                {
                    return null;
                }

                else if (node.value == data)
                {
                    return node;
                }

                else if (node.value < data)
                {
                    return (node.rightNode);
                }

                else if (node.value > data)
                {
                    return (node.leftNode);
                }
            return node;
        }
    }
}
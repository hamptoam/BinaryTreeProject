using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySeachTree tree = new BinarySeachTree();
            Node node = new Node(7);
            tree.Add(node, 7);
        }
    }
}

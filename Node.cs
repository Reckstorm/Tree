using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Node
    {
        public int? value { get; set; }
        public Node? prev { get; set; }
        public Node? left { get; set; }
        public Node? right { get; set; }
        public Node() { }
        public Node(int value, Node prev = null)
        {
            this.value = value;
            this.prev = prev;
        }
        public Node(Node node)
        {
            this.value = node.value;
            this.prev = node.prev;
            this.left = node.left;
            this.right = node.right;
        }
        public void PrintNode()
        {
            Console.WriteLine(this.value.ToString());
        }
        public void ClearNode()
        {
            this.prev = null;
            this.right = null;
            this.left = null;
            this.value = null;
        }
    }
}

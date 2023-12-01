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
        public void Add(int value)
        {
            if (value < this.value && this.left == null)
            {
                this.left = new Node(value, this);
                return;
            }
            if (value < this.value && this.left != null) this.left.Add(value);
            if (value > this.value && this.right == null)
            {
                this.right = new Node(value, this);
                return;
            }
            if (value > this.value && this.right != null) this.right.Add(value);
        }
        public void Print()
        {
            if(this.prev != null) this.left?.Print();
            this.PrintNode();
            this.right?.Print();
        }

        private void PrintNode()
        {
            Console.WriteLine(this.value.ToString());
        }

        public Node? Find(int value)
        {
            Node? node = null;
            if (value == this.value)
            {
                node = this;
                return node;
            }
            if (this.left != null && value <= this.left.value) node = this.left.Find(value);
            else if (this.right != null && value >= this.right.value) node = this.right.Find(value);
            return node;
        }

        public Node MinNode()
        {
            Node node = this; ;
            if (node.left != null) node = node.left.MinNode();
            return node;
        }

        public Node MaxNode()
        {
            Node node = this; ;
            if (node.right != null) node = node.right.MaxNode();
            return node;
        }

        public Node Remove(Node? node)
        {
            node ??= this;
            if (node != null && node.prev == null) 
            {
                Node leftTree = node.left == null ? null : node.left;
                Node rightTree = node.right == null ? null : node.right;
                node.ClearNode();
                left
            }
            return this;
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

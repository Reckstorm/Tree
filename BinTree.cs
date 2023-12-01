using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class BinTree
    {
        public Node Root { get; private set; }
        public BinTree(Node root)
        {
            Root = root;
        }
        public void Add(int value, Node? node = null)
        {
            node ??= Root;
            if (value < node.value && node.left == null)
            {
                node.left = new Node(value, node);
                return;
            }
            if (value < node.value && node.left != null) Add(value, node.left);
            if (value > node.value && node.right == null)
            {
                node.right = new Node(value, node);
                return;
            }
            if (value > node.value && node.right != null) Add(value, node.right);
        }
        public void Print(Node? node = null)
        {
            if (node != null)
            {
                Print(node.left);
                node.PrintNode();
                Print(node.right);
            }
        }

        public Node? Find(int value, Node? node = null)
        {
            node ??= Root;
            if (value == node.value) return node;
            if (node.left != null && value <= node.value) node = Find(value, node.left);
            else if (node.right != null && value >= node.value) node = Find(value, node.right);
            return node;
        }

        public Node MinNode(Node? node = null)
        {
            node ??= Root;
            if (node.left != null) node = MinNode(node.left);
            return node;
        }
        public Node MaxNode(Node? node = null)
        {
            node ??= Root;
            if (node.right != null) node = MaxNode(node.right);
            return node;
        }

        public Node? Next(Node? node = null)
        {
            node ??= Root;
            if (node.right != null)
            {
                node = MinNode(node.right);
                return node;
            }
            return null;
        }

        public Node? Previous(Node? node = null)
        {
            node ??= Root;
            if (node.left != null)
            {
                node = MaxNode(node.left);
                return node;
            }
            return null;
        }

        public void Delete(Node? node = null)
        {
            node ??= Root;
            if (node.left != null) Delete(node.left);
            if (node.right != null) Delete(node.right);
            node.ClearNode();
        }
    }
}

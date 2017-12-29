using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node
    {
        private int _data;

        public Node left, right;
        public Node(int d)
        {
            _data = d;
            left = right = null;
        }

        //insert a node in the tree. It travese and figure out where to add the node
        public void InsertNode(int data)
        {
            if (_data > data)
            {
                if (left == null)
                {
                    left = new Node(data);
                }
                else
                {
                    left.InsertNode(data);
                }
            }
            else if (_data < data)
            {
                if (right == null)
                {
                    right = new Node(data);
                }
                else
                {
                    right.InsertNode(data);
                }
            }

        }

        //Tree printer
        public void NodePrinter()
        {
            if (left != null)
            {
                left.NodePrinter();
            }
            Console.WriteLine(_data);

            if (right != null)
            {
                right.NodePrinter();
            }
        }

        //searching for spacific node
        internal bool NodeSearch(int value)
        {
            if (_data == value)
            {
                return true;
            }

            if (_data > value)
            {
                if (left == null)
                {
                    return false;
                }
                return left.NodeSearch(value);

            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                return right.NodeSearch(value);
            }

        }

        //find nodes within range
        internal void FilterSubTree(int min, int max)
        {
            if (_data > min)
            {
                if (left != null)
                {
                    left.FilterSubTree(min, max);
                }

            }
            if (_data >= min && _data <= max)
            {
                //when it find s the node within the range it will create a new subtree
                Node subTree = new Node(_data);
                subTree.InsertNode(_data);
                subTree.NodePrinter();

            }
            if (_data < max)
            {
                if (right != null)
                {
                    right.FilterSubTree(min, max);
                }

            }
        }
    }
}

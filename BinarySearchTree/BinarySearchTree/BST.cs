using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BST
    {
        private Node _root;

        public bool IsEmpty { get; set; }

        public BST()
        {
            _root = null;
        }


        public Node Insert(int data)
        {
            if (_root == null)
            {
                _root = new Node(data);
            }
            else
            {

                _root.InsertNode(data);
            }

            return _root;
        }

        internal void InOrderBST()
        {
            if (_root != null)
            {
                _root.NodePrinter();
            }
        }

        internal bool FindNode(int value)
        {
            return _root.NodeSearch(value);
        }

        internal void FilterNodesWithinRange(int min, int max)
        {
            if (_root == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                _root.FilterSubTree(min, max);
                
            }

        }


    }
}

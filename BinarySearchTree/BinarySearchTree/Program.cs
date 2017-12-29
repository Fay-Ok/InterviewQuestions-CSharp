using System;

namespace BinarySearchTree
{
    class Program
    {

        //create a BST
        //print the tree=> know inorder or pre order terms
        //search for a node
        //insert and delete a node
        class Tree
        {
          
                public static void Main(String[] args)
            {
                int min= 20,max= 30;

                BST bst = new BST();
                
                bst.Insert(20);
                bst.Insert(8);
                bst.Insert(4);
                bst.Insert(22);
                bst.Insert(14);
                bst.Insert(30);
                bst.Insert(35);

                //bst.InOrderBST();
                bst.FilterNodesWithinRange(min, max);

                Console.WriteLine(bst.FindNode(23));
                Console.ReadLine();
            }
        }

    }
}

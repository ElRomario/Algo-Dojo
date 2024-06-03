using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Situation
{
    public class BinarySearchTree
    {
        Node root;

        public void insert(Node node)
        { root = insertHelper(root, node); }
        private Node insertHelper(Node root, Node node)
        {
            int data = node.data;
            if (root == null)
            {
                root = node;
                return root;
            }

            else if (data < root.data)
            {
                root.left = insertHelper(root.left, node);
            }
            else
            {
                root.right = insertHelper(root.right, node);
            }




            return root;
        }
        public void display()
        { displayHelper(root); }
        private void displayHelper(Node root)
        {
            if (root != null)
            {
                displayHelper(root.left);
                Console.WriteLine(root.data);
                displayHelper(root.right);
            }


        }
        public Boolean search(int data)
        {
            return searchHelper(root, data);
        }
        private Boolean searchHelper(Node root, int data)
        {
            if (root == null)
                return false;
            else if (root.data == data)
                return true;
            else if (root.data > data)
            {
                return searchHelper(root.left, data);
            }
            else
            {
                return searchHelper(root.right, data);
            }




        }
        public void remove(int data)
        {
            if (search(data))
                RemoveHelper(root, data);
            else
                Console.WriteLine("DATA DOES NOT EXIST");

        }

        private Node RemoveHelper(Node root, int data)
        {
            if (root == null)
                return root;
            else if (data < root.data)
            {
                root.left = RemoveHelper(root.left, data);
            }
            else if (data > root.data)
            {
                root.right = RemoveHelper(root.right, data);
            }
            else
            {
                if (root.left == null && root.right == null)
                {
                    root = null;


                }
                else if (root.right != null)
                {
                    root.data = successor(root);
                    root.right = RemoveHelper(root.right, root.data);
                }
                else
                {
                    root.data = successor(root);
                    root.left = RemoveHelper(root.left, root.data);

                }
            }
                return root;
            
        }
            int successor(Node root)//find least child below the right child of this root node
            {
                root = root.right;
                while (root.left != null)
                {
                    root = root.left;
                }
                return root.data;
            }
            int predecessor(Node root)
            {
                root = root.left;
                while (root.right != null)
                {
                    root = root.right;
                }
                return root.data;

            }
        
    }
}

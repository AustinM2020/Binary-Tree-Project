using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        Node root = null;

        public void Add(int info)
        {
            Node node = new Node();
            node.data = info;

            if (root == null)
            {
                root = node;
                return;
            }

            Node temp = root;
            if (Search(node.data, temp.data) == true && temp.leftChild == null)
            {
                temp.leftChild = node;
            }
            else if (Search(node.data, temp.data) == false && temp.rightChild == null)
            {
                temp.rightChild = node;
            }
            else if (Search(node.data, temp.data) == true && temp.leftChild != null)
            {
                do
                {
                    temp = temp.leftChild;
                }
                while (temp.leftChild != null);
                if (Search(node.data, temp.data) == true)
                {
                    temp.leftChild = node;
                }
                else if (Search(node.data, temp.data) == false)
                {
                    temp.rightChild = node;
                }
            }
            else if (Search(node.data, temp.data) == false && temp.rightChild != null)
            {
                do
                {
                    temp = temp.rightChild;
                }
                while (temp.rightChild != null);
                if (Search(node.data, temp.data) == true)
                {
                    temp.leftChild = node;
                }
                else if (Search(node.data, temp.data) == false)
                {
                    temp.rightChild = node;
                }
            } 
        }
        public bool Search(int added, int prev)
        {
            if (added < prev)
            {
                return true;
            }
            else if (added == prev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

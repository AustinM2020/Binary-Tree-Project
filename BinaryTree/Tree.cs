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
            while (temp.leftChild != null || temp.rightChild != null)
            {
                if (temp.leftChild != null && Search(node.data, temp.data) == true)
                {
                    temp = temp.leftChild;
                    if (temp.leftChild == null)
                    {
                        break;
                    }
                }
                else if (temp.rightChild != null && Search(node.data, temp.data) == false)
                {
                    temp = temp.rightChild;
                    if (temp.rightChild == null)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            } 
            if (Search(node.data, temp.data) == true)
            {
                temp.leftChild = node;
            }
            else if (Search(node.data, temp.data) == false)
            {
                temp.rightChild = node;
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

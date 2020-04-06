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
            if (Search(node.data, temp.data) == true)
            {
                if (Search(node.data, temp.data) == true && temp.leftChild == null)
                {
                    temp.leftChild = node;
                }
                else if (Search(node.data, temp.data) == false && temp.rightChild == null)
                {
                    temp.rightChild = node;
                }
                else
                {
                    temp = temp.leftChild;
                    if (Search(node.data, temp.data) == true)
                    {
                        if (temp.leftChild == null)
                        {
                            temp.leftChild = node;
                        }
                        else
                        {
                            while (temp.leftChild != null)
                            {
                                temp = temp.leftChild;
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
                    }
                    else if (Search(node.data, temp.data) == false)
                    {
                        if (temp.rightChild == null)
                        {
                            temp.rightChild = node;
                        }
                        else
                        {
                            while (temp.rightChild != null)
                            {
                                temp = temp.rightChild;
                            }
                            if (Search(node.data, temp.data) == true)
                            {
                                temp.leftChild = node;
                            }
                            else if(Search(node.data, temp.data) == false)
                            {
                                temp.rightChild = node;
                            }   
                        }
                    }
                }
            }
            else if (Search(node.data, temp.data) == false)
            {
                if (Search(node.data, temp.data) == true && temp.leftChild == null)
                {
                    temp.leftChild = node;
                }
                else if (Search(node.data, temp.data) == false && temp.rightChild == null)
                {
                    temp.rightChild = node;
                }
                else
                {
                    temp = temp.rightChild;
                    if (Search(node.data, temp.data) == true)
                    {
                        if (temp.leftChild == null)
                        {
                            temp.leftChild = node;
                        }
                        else
                        {
                            while (temp.leftChild != null)
                            {
                                temp = temp.leftChild;
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
                    }
                    else if(Search(node.data, temp.data) == false)
                    {
                        if (temp.rightChild == null)
                        {
                            temp.rightChild = node;
                        }
                        else
                        {
                            while (temp.rightChild != null)
                            {
                                temp = temp.rightChild;
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
                    }    
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

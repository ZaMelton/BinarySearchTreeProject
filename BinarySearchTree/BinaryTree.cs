using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        public Node<T> root;

        public BinaryTree()
        {

        }

        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if(root == null)
            {
                root = node;
            }
            else
            {
                Node<T> current = root;
                bool placed = false;

                while (!placed)
                {
                    if (node.data.CompareTo(current.data) > 0)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = node;
                            placed = true;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    else
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = node;
                            placed = true;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                }

            }
        }

        public Node<T> Search(int value)
        {
            Node<T> current = root;

            bool found = false;

            while (!found)
            {
                if (value.CompareTo(current.data) > 0)
                {
                    if (current.data.CompareTo(value) == 0)
                    {
                        found = true;
                        return current;
                    }
                    else
                    {
                        if(current.rightChild == null)
                        {
                            return null;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                }
                else
                {
                    if (current.data.CompareTo(value) == 0)
                    {
                        found = true;
                        return current;
                    }
                    else
                    {
                        if (current.leftChild == null)
                        {
                            return null;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                }
            }
            return current;
        }
    }
}

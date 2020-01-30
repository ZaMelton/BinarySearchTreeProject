using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T>
    {
        public Node<T> leftChild;
        public Node<T> rightChild;
        public T data;

        public Node(T data)
        {
            this.data = data;
        }
    }
}

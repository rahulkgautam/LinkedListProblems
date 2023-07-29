using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class Node<T> where T : IComparable<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class SortedLinkedList<T> where T : IComparable<T>
    {
    
        public Node<T> head;

        public SortedLinkedList()
        {
            head = null;
        }

        public void Add(T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            
            if (head == null || newData.CompareTo(head.data) < 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }

            Node<T> current = head;
            while (current.next != null && newData.CompareTo(current.next.data) >= 0)
            {
                current = current.next;
            }

            newNode.next = current.next;
            current.next = newNode;
        }
        public void Display()
        {
            Node<T> temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked is Emptyp");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

    }
}

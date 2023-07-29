using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted at lastNode", newNode.data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
                Console.WriteLine("{0} is inserted at lastNode", newNode.data);
            }
        }
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public Node Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == key)
                {
                    return current;
                }
                current = current.next;
            }
            return null; 
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void InsertAfterKey(int key, int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == key)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
            }
        }
        public void Display()
        {
            Node temp = head;
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

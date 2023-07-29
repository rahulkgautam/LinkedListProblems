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
        public void InsertBetweenNodes(int data1, int data2, int newData)
        {
            Node newNode = new Node(newData);

            Node temp = head;
            while (temp != null && temp.data != data1)
            {
                temp= temp.next;
            }
            if (temp == null)
                return;
            newNode.next = temp.next;
            temp.next = newNode;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    class CustomLinkedList
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
        public void Append(int data)
        {
            AddLast(data);
        }
        public void Search(int data)
        {
            bool isFound = false;
            Node temp = head;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        isFound = true;
                        Console.WriteLine("{0} Node is Found", temp.data);
                        break;
                    }
                    else
                        temp = temp.next;
                }
                if (!isFound)
                    Console.WriteLine("{0} Node is not found", data);
            }
            else
                Console.WriteLine("LinkedList is Empty");

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

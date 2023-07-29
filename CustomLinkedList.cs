using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class CustomLinkedList
    {
        public Node head;
        
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
        public void Delete(int key)
        {
            if (head == null)
                return;

            // If the node to be deleted is the head node
            if (head.data == key)
            {
                head = head.next;
                return;
            }

            Node current = head;
            Node prev = null;
            while (current != null && current.data != key)
            {
                prev = current;
                current = current.next;
            }
            if (current == null)
                return;
            
            prev.next = current.next;
        }
        public int Size()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
        }
}

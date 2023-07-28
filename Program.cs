using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To liked List Programs!");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddFirst(56);
            customLinkedList.AddFirst(30);
            customLinkedList.AddFirst(70);
            customLinkedList.Display();
        }
    }
}

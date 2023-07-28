using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To liked List Programs!");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddLast(56);
            customLinkedList.AddLast(30);
            customLinkedList.AddLast(70);
            customLinkedList.Display();
        }
    }
}

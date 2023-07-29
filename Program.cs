using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To liked List Programs!");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.Append(56);
            customLinkedList.Append(30);
            customLinkedList.Append(70);
            customLinkedList.Search(30);
            customLinkedList.Display();
           
        }
    }
}

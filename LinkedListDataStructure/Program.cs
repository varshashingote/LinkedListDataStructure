using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List DataStructure!!!");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            //customLinkedList.Add(56);
            //customLinkedList.Add(30);
            //customLinkedList.Add(70);
            //customLinkedList.Display();
            //customLinkedList.AddFirst(70);
            //customLinkedList.AddFirst(30);
            //customLinkedList.AddFirst(56);
            //customLinkedList.Display();
            //Console.ReadLine();
            customLinkedList.Append(56);
            customLinkedList.Append(30);
            customLinkedList.Append(70);
            customLinkedList.Display();
            Console.ReadLine();



        }
    }
}

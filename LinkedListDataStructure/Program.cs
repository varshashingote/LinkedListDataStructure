using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LinkedListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List DataStructure!!!");
            CustomLinkedList customLinkedList = new CustomLinkedList();

            Console.WriteLine("Enter Your Choice 1.ADDFirst \n2.AddLast \n3.Append \n4.InsertElement" +
                " \n5.RemoveFirstElement \n6.RemovelastElement \n7.search");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    customLinkedList.Add(56);
                    customLinkedList.Add(30);
                    customLinkedList.Add(70);
                    customLinkedList.Display();
                    Console.ReadLine();

                    break;
                case 2:
                    customLinkedList.AddFirst(70);
                    customLinkedList.AddFirst(30);
                    customLinkedList.AddFirst(56);
                    customLinkedList.Display();
                    Console.ReadLine();
                    break;
                case 3:
                    customLinkedList.Append(56);
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    customLinkedList.Display();
                    Console.ReadLine();
                    break;
                case 4:
                    customLinkedList.Add(56);
                    customLinkedList.Add(70);
                    customLinkedList.insertAtMid(30);
                    customLinkedList.Display();
                    Console.ReadLine();
                    break;
                case 5:
                    customLinkedList.Add(56);
                    customLinkedList.Add(30);
                    customLinkedList.Add(70);
                    customLinkedList.RemoveFirst();
                    customLinkedList.Display();
                    Console.ReadLine();
                    break;
                case 6:
                    customLinkedList.Add(30);
                    customLinkedList.Add(70);
                    customLinkedList.RemoveLast();
                    customLinkedList.Add(56);
                    customLinkedList.Display();
                    Console.ReadLine();
                    break;
                case 7:
                    customLinkedList.Add(56);
                    customLinkedList.Add(30);
                    customLinkedList.Add(70);
                    customLinkedList.Search(60);
                    customLinkedList.Display();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            
            




        }
    }
}

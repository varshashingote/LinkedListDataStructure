using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListDataStructure
{
     class CustomLinkedList
    {
        public Node head; 
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Inserted into Linked List :  {0}", node.data);
        }
       
        public void AddFirst(int data)
        {

            Node Node = new Node(data);
            Node.next = this.head;
            this.head = Node;
            Console.WriteLine("{0}is inserted into LikedList",Node.data);
        }
        public void Append(int data)
        {
            Node Node = new Node(data);
            Node.next = this.head;
            this.head = Node;
            Console.WriteLine("{0} is inserted ",Node.data);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    

        }
        public void insertAtMid(int data)
        {
            // if list is empty 
            if (head == null)
                head = new Node(data);
            else
            {
                // get a new node 
                Node newNode = new Node(data);

                Node temp = head;
                int len = 0;

                // calculate length of the linked list 
                //, i.e, the number of nodes 
                while (temp != null)
                {
                    len++;
                    temp = temp.next;
                }

                // 'count' the number of nodes after which 
                // the new node is to be inserted 
                int count = ((len % 2) == 0) ? (len / 2) :
                                            (len + 1) / 2;
                temp = head;

                // 'ptr' points to the node after which 
                // the new node is to be inserted 
                while (count-- > 1)
                    temp = temp.next;

                // insert the 'newNode' and adjust 
                // the required links 
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }





        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine(" Linked List is Empty ");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

    
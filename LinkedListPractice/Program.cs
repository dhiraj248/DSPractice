using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            singlyLinkList objlist = new singlyLinkList();
            Node node = new Node(10);
            objlist.head = node;
            objlist.addNodeFromFront(12);
            objlist.addNodeFromFront(14);
            objlist.addNodeFromFront(1);
            objlist.addNodeFromFront(18);
            objlist.addNodeFromFront(22);
            objlist.addNodeFromFront(6);
            objlist.addNodeFromFront(8);

            objlist.addFromRear(9);
            objlist.addFromRear(7);
            objlist.addFromRear(5);
            objlist.CreateASortedLinkList(5);
            objlist.CreateASortedLinkList(15);
            objlist.CreateASortedLinkList(4);
            objlist.CreateASortedLinkList(3);
            objlist.CreateASortedLinkList(12);
            objlist.CreateASortedLinkList(125);
            int[] number = { 2, 22, 43, 75, 16, 1, 6 };
            foreach (int i in number)
            {
                objlist.CreateASortedLinkList(i);

            }
           // objlist.InsertingItemInSortedLinkList(31);
            objlist.PrintList(objlist);
            //Console.ReadKey();

            //objlist.DeleteFromLinkList(31);
            //Console.WriteLine("\n deleted the given element\n");
            problemsOnLinkList lnklist = new problemsOnLinkList();
            Console.WriteLine("Please select the following option for sorting");
            Console.WriteLine("B: Bubble Sort");
            Console.WriteLine("S: Selection Sort");
            Console.WriteLine("I: Insertion Sort");
            string sortoption;
            sortoption = Console.ReadLine();
            switch(sortoption)
            {
                case "B":
                    lnklist.sortLinkListbyBubble(objlist.head);
                    break;
                case "S":
                    lnklist.SelectionSort(objlist.head);
                    break;
                case "I":
                    lnklist.insertionSort(objlist.head);
                    break;
                default:
                    Console.WriteLine("Wrong option!");
                    break;
            }
            objlist.PrintList(objlist);
            
            Console.ReadKey();
        }
    }  
}

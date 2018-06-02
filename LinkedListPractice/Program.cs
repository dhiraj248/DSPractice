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
            objlist.addFromRear(2345);
            //objlist.CreateASortedLinkList(5);
            //objlist.CreateASortedLinkList(15);
            //objlist.CreateASortedLinkList(4);
            //objlist.CreateASortedLinkList(3);
            //objlist.CreateASortedLinkList(12);
            //objlist.CreateASortedLinkList(125);
            //int[] number = { 2, 22, 43, 75, 16, 1, 6 };
            //foreach (int i in number)
            //{
            //    objlist.CreateASortedLinkList(i);

            //}
            // objlist.InsertingItemInSortedLinkList(31);
            objlist.PrintList(objlist);
            //Console.ReadKey();

            //objlist.DeleteFromLinkList(31);
            //Console.WriteLine("\n deleted the given element\n");
            problemsOnLinkList lnklist = new problemsOnLinkList();
            Console.WriteLine("\n Please select the following option for sorting");
            Console.WriteLine("1: Bubble Sort");
            Console.WriteLine("2: Selection Sort");
            Console.WriteLine("3: Insertion Sort");
            Console.WriteLine("4: Swap node without swaping data");
            Console.WriteLine("5: Reverse a link list");
            Console.WriteLine("6: Iterative length of a link list");
            Console.WriteLine("7: Recursive length of a linked list");
            Console.WriteLine("8: Get the middle item of a linked list");
            Console.WriteLine("9: Get the count of given item in a linked list");
            Console.WriteLine("10: Merge two sorted link list.");
            string sortoption;
            sortoption = Console.ReadLine();

            switch (sortoption)
            {
                case "1":
                    lnklist.sortLinkListbyBubble(objlist.head);
                    break;
                case "2":
                    lnklist.SelectionSort(objlist.head);
                    break;
                case "3":
                    lnklist.insertionSort(objlist.head);
                    break;
                case "4":
                    Console.WriteLine("\n please enter nodes to swap");
                    int x, y;
                    Int32.TryParse(Console.ReadLine(), out x);
                    Int32.TryParse(Console.ReadLine(), out y);
                    lnklist.SwapNodes(x, y, ref objlist.head);
                    break;
                case "5":
                    lnklist.Reversenew(ref objlist.head);
                    break;
                case "6":
                    int l = lnklist.GetLength(objlist.head);
                    Console.WriteLine("the length of list is {0}", l);
                    break;
                case "7":
                    int ll = lnklist.getRecursiveLength(objlist.head);
                    Console.WriteLine("the length of list is {0}", ll);
                    break;
                case "8":
                    int miditem = lnklist.GetMidItemInList(objlist.head);
                    Console.WriteLine("the middle item of given list is {0}", miditem);
                    break;
                case "9":
                    Console.WriteLine("Please enter the item to look into");
                    int givenItem = 0;
                    Int32.TryParse(Console.ReadLine(), out givenItem);
                    // int itemCount = lnklist.GetItemCount(objlist.head,givenItem);
                    int itemCount = lnklist.GetFrequency(objlist.head, givenItem);
                    Console.WriteLine($"the count of  {givenItem} in given list is {itemCount}");
                    break;
                case "10":
                    singlyLinkList l1 = new singlyLinkList();
                    l1.head = new Node(2);
                    for (int j = 2; j < 6; j++)
                        l1.addFromRear(2*j);
                    singlyLinkList l2 = new singlyLinkList();
                    l2.head = new Node(5);
                    for (int k = 7; k < 14; k+=2)
                        l2.addFromRear(k);
                    Node h = lnklist.SortedMerge(l1.head, l2.head);
                    objlist.head = h;
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

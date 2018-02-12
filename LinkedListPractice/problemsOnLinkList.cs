using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{

    class problemsOnLinkList
    {
        singlyLinkList objList = new singlyLinkList();
        public void sortLinkListbyBubble(Node head)
        {
            Node currNode, nextNode, lastNode;
            bool isswaped;
            lastNode = null;
            if (head != null)
            {
                do
                {
                    isswaped = false;
                    currNode = head;
                    while (currNode.Next != lastNode)
                    {
                        nextNode = currNode.Next;
                        if (currNode.data > nextNode.data)
                        {
                            objList.swapNodes(currNode, nextNode);
                            isswaped = true;
                        }
                        currNode = currNode.Next;
                    }
                    lastNode = currNode;
                } while (isswaped);
            }
        }

        public void SelectionSort(Node head)
        {
            Node currNode, minNode, lastNode;
            bool isSorted;
            if (head != null)
            {
                lastNode = null;
                do
                {
                    isSorted = false;
                    currNode = head;
                    while (currNode.Next != lastNode)
                    {
                        if (currNode.data > currNode.Next.data)
                        {
                            minNode = currNode.Next;
                            objList.swapNodes(currNode, minNode);
                            isSorted = true;
                        }
                        currNode = currNode.Next;
                    }
                    lastNode = currNode;
                } while (isSorted);
            }
        }
        Node sortedNode;
        public void insertionSort(Node head)
        {
            Node currNode;
            currNode = head;
            sortedNode = null;
            while (currNode != null)
            {
                Node NextNode = currNode.Next;
                InsertSorted(currNode);
                currNode = NextNode;
            }
            head = sortedNode;

        }

        private void InsertSorted(Node newNode)
        {
            if (sortedNode == null || sortedNode.data > newNode.data)
            {
                newNode.Next = sortedNode;
                sortedNode = newNode;
            }
            else
            {
                Node currNode = sortedNode;
                while(currNode.Next!=null && currNode.Next.data<newNode.data)
                {
                    currNode = currNode.Next;
                }
                newNode.Next = currNode.Next;
                currNode.Next = newNode;
            }
        }
    }
}

﻿using System;
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
                while (currNode.Next != null && currNode.Next.data < newNode.data)
                {
                    currNode = currNode.Next;
                }
                newNode.Next = currNode.Next;
                currNode.Next = newNode;
            }
        }

        //Swap two given nodes without swapping data
        public void SwapNodes(int x, int y, ref Node head)
        {
            Node Xnode, Ynode, PrevX, PrevY;
            Xnode = Ynode = PrevX = PrevY = null;
            Xnode = head;
            while (Xnode != null && Xnode.data != x)
            {
                PrevX = Xnode;
                Xnode = Xnode.Next;
            }
            Ynode = head;
            while (Ynode != null && Ynode.data != y)
            {
                PrevY = Ynode;
                Ynode = Ynode.Next;
            }
            if (Xnode == null && Ynode == null)
            {
                return;
            }
            if (PrevX != null)
            {
                PrevX.Next = Ynode;
            }
            else
            {
                head = Ynode;
            }
            if (PrevY != null)
            {
                PrevY.Next = Xnode; ;
            }
            else
            {
                head = Xnode;
            }
            Node temp = Ynode.Next;
            Ynode.Next = Xnode.Next;
            Xnode.Next = temp;
        }
        [Obsolete]
        //this appreoach is not inplace 
        public void Reverse(ref Node head)
        {
            Node newHead, currNode, prevNode;
            currNode = head;
            prevNode = null;
            newHead = null; prevNode = null;
            while (currNode != null)
            {
                if (newHead != null)
                    prevNode = newHead;
                newHead = new Node(currNode.data);
                newHead.Next = prevNode;
                currNode = currNode.Next;
            }
            head = newHead;
        }
        public void Reversenew(ref Node head)
        {
            Node currNode, prevNode, nextNode;
            currNode = head;
            prevNode = nextNode = null;
            while (currNode != null)
            {
                nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            head = prevNode;
        }

        public int GetLength(Node head)
        {
            Node currNode = head;
            int counter = 0;
            while (currNode != null)
            {
                currNode = currNode.Next;
                counter++;
            }
            return counter;
        }

        public int getRecursiveLength(Node head)
        {
            if (head == null)
                return 0;
            else
            {
                return 1 + getRecursiveLength(head.Next);
            }
        }
        public int GetMidItemInList(Node head)
        {
            int midItem = -1;
            Node currNode, midCheck;
            midCheck = currNode = head;
            if (head != null)
            {
                while (currNode != null && currNode.Next != null)
                {
                    currNode = currNode.Next.Next;
                    midCheck = midCheck.Next;
                }
                midItem = midCheck.data;
            }
            return midItem;
        }

        public int GetItemCount(Node head, int givenItem)
        {
            Node currNode = null;
            int itemCount = 0;
            if (head != null)
            {
                currNode = head;
                while (currNode != null)
                {
                    if (currNode.data == givenItem)
                    {
                        itemCount++;
                    }
                    currNode = currNode.Next;
                }
            }
            return itemCount;
        }
        int count = 0;
        public int GetFrequency(Node head, int givenItem)
        {

            Node currNode = head;
            if (currNode == null)
            {
                return count;
            }
            else
            {
                if (currNode.data == givenItem)
                {
                    count++;
                }
                GetFrequency(currNode.Next, givenItem);
            }
            return count;
        }

        public Node SortedMerge(Node head1, Node head2)
        {
            Node Mergedhead = null;
            Node currNode1, currNode2, currMerged;
            if (head1 != null && head2 != null)
            {
                currNode1 = head1;
                currNode2 = head2;
                currMerged = null;
                while (currNode2 != null)
                {
                    if (Mergedhead == null)
                    {
                        if (currNode1.data < currNode2.data)
                        {
                            currMerged = currNode1;
                            currNode1 = currNode1.Next;
                        }
                        else
                        {
                            currMerged = currNode2;
                            currNode2 = currNode2.Next;
                        }
                        Mergedhead = currMerged;
                    }
                    else
                    {
                        if (currNode1 != null && currNode2 != null)
                        {
                            if (currNode1.data < currNode2.data)
                            {
                                currMerged.Next = currNode1;
                                currNode1 = currNode1.Next;
                            }
                            else
                            {
                                currMerged.Next = currNode2;
                                currNode2 = currNode2.Next;
                            }
                            currMerged = currMerged.Next;
                        }
                    }
                }
                if(currNode2!=null)
                {
                    currMerged.Next = currNode2;
                }
            }
            return Mergedhead;
        }

    }
}

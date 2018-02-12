using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    class singlyLinkList
    {
        public Node head;
        public void addNodeFromFront(int data)
        {
            Node new_node = new Node(data);
            new_node.Next = head;
            head = new_node;
        }
        public void PrintList(singlyLinkList objList)
        {

            Node current_node = objList.head;
            do
            {
                Console.Write($"{current_node.data} ");
                current_node = current_node.Next;
            } while (current_node != null);
        }

        public void CreateASortedLinkList(int data)
        {
            Node current_Node, Prev_Node, new_Node;
            new_Node = new Node(data);
            bool nodeNotAdded = true;
            if (head != null)
            {
                current_Node = head;
                Prev_Node = current_Node;
                while (current_Node != null)
                {
                    if (current_Node.data < data)
                    {
                        Prev_Node = current_Node;
                        current_Node = current_Node.Next;
                    }
                    else
                    {
                        if (current_Node == head)
                            head = new_Node;
                        else
                            Prev_Node.Next = new_Node;
                        new_Node.Next = current_Node;
                        nodeNotAdded = false;
                        break;
                    }
                }
                if (nodeNotAdded)
                    Prev_Node.Next = new_Node;
            }
        }

        public void addFromRear(int data)
        {
            Node current_node;
            Node new_node = new Node(data);
            if (head != null)
            {
                current_node = head;
                while (current_node.Next != null)
                {
                    current_node = current_node.Next;
                }
                current_node.Next = new_node;
            }
        }

        public void InsertingItemInSortedLinkList(int data)
        {
            Node prevNode, currNode, newNode;
            newNode = new Node(data);
            if (head != null)
            {
                currNode = head;
                prevNode = currNode;
                while (currNode != null)
                {
                    if (currNode.data < data)
                    {
                        prevNode = currNode;
                        currNode = currNode.Next;
                    }
                    else
                    {
                        if (currNode == head)
                        {
                            head = newNode;
                        }
                        else
                        {
                            prevNode.Next = newNode;
                        }
                        newNode.Next = currNode;
                        currNode = currNode.Next;
                        break;
                    }
                }

            }
        }

        public void DeleteFromLinkList(int data)
        {
            Node currNodde, PrevNode;
            if (head != null)
            {
                currNodde = head;
                PrevNode = head;
                while (currNodde != null)
                {
                    if (currNodde.data != data)
                    {
                        PrevNode = currNodde;
                        currNodde = currNodde.Next;
                    }
                    else
                    {
                        PrevNode.Next = currNodde.Next;
                        break;
                    }
                }
            }
        }
        
        public void swapNodes(Node currNode, Node nextNode)
        {
            int temp = nextNode.data;
            nextNode.data = currNode.data;
            currNode.data = temp;            
        }        
    }
}

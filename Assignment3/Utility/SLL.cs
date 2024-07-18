﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.ProblemDomain;

namespace Assignment3.Utility
{
    //SLL class to implement ILinkedListADT Interface:
    public class SLL : ILinkedListADT
    {
        private Node head;
        private int count;
        //Constructor:
        public SLL()
        {
            //head references first node
            //count keeps track of all items in list
            head = null;
            count = 0;
        }
        //IsEmpty method: Checks if linked list is empty by checking count = 0
        //returns true if list is empty
        public bool IsEmpty()
        {
            return count == 0;
        }
        //clear method: Clears the list
        //Reset head, reset count
        public void clear()
        {
            head = null;
            count = 0;
        }
        //AddLast method: Adds a new node with the value to the end of the list
        public void AddLast(User value)
        {
            Node newNode = new Node(value);
            //Set head to newNode if list IsEmpty:
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                //Moving throught nodes that aren't empty to get to the end:
                while (current.Next != null)
                {
                    current = current.Next;
                }
                //Set last node to newNode:
                current.Next = newNode;
            }
            count++;
        }
        //AddFirst method: Adds a new node with the value to the beginning of the list
        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            //Set head to newNode if list IsEmpty:
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                //set newNodes next head to current head:
                newNode.Next = head;
                //set head to newNode value:
                head = newNode;
            }
            count++;
        }
        //Add method: Adds a new node with the value to specified position in the linked list
        public void Add(User value, int index)
        {
            //Index out of range exception:
            if (index<0 & index>count)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }
            //If index = 0 add value to first position:
            if (index == 0)
            {
                AddFirst(value);
            }
            //If index = count (last position) add value to last position:
            else if (index == count)
            {
                AddLast(value);
            }
            //All other positions:
            else
            {
                Node newNode = new Node(value);
                Node current = head;
                //For loop from index 0 to node before target index:
                for (int i = 0; i < index - 1; i++)
                {
                    //node before target index:
                    current = current.Next;
                }
                newNode.Next = current.Next;
                //Setting current's next to newNode value:
                current.Next = newNode;
                count++;
            }
        }
        //Replace method: Replaces value at specific position in linked list
        public void Replace(User value, int index)
        {
            //Index out of range exception:
            if(index<0 & index>count)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }

            Node current = head;
            //For loop from index 0 to target node:
            for (int i = 0;i < index; i++)
            {
                //Target node:
                current = current.Next;
            }
            //Setting current node to value:
            current.Data = value;
        }
        //Count method: Returns total count of items in the list
        public int Count()
        {
            return count;
        }
        //RemoveFirst method: Removes first node from linked list
        public void RemoveFirst()
        {
            //Empty List, Invalid Operation Exception:
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot Remove! List is empty!");
            }
            //Setting head to next node:
            head = head.Next;
            count--;
        }
        //RemoveLast method: removes last node from linked list
        public void RemoveLast()
        {
            //Empty List, Invalid Operation Exception:
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot Remove! List is empty!");
            }
            //if only 1 node in list, set head to null:
            if (count == 1)
            {
                head = null;
            }
            else
            {
                Node current = head;
                //while loop goes to second last node:
                while (current.Next.Next != null)
                {
                    //second last node:
                    current = current.Next;
                }
                //sets last to null:
                current.Next = null;
            }
            count--;
        }

    }
}

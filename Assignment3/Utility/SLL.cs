using System;
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
        public void Add(User value, int index)
        {

        }
    }
}

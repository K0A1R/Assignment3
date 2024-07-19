using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    //Node Class for each node in the Linked List:
    public class Node
    {
        public User Data { get; set; }
        public Node Next { get; set; }
        //Constructor:
        public Node(User data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }
}

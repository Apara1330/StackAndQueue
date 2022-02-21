using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
     public class Node
    {
        public int data;
        public Node next;

        public Node(int data)//constructor is used to initialize the data
        {
            this.data = data;
            this.next = null;
        }
    }
}

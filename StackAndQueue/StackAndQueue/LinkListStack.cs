using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
     class LinkListStack
    {
        public Node top;
            
        public void Push(int value)// to add element into stack.  
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = this.top;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display() // display the stack elements.
        {
            Node temp = this.top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            while (temp != null)
            {
                Console.WriteLine("Data in Stack :" + temp.data);
                temp = temp.next;
            }
        }
    }
}
    


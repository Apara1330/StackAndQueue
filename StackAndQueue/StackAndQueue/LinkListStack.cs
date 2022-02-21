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
        
        public void Peak()//to find the top element of stack
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is Peak element of Stack", top.data);
        }
        
        public void Pop()//to remove the top element from stack.
        {
            Peak();
            int deleteNode = this.top.data;
            this.top = top.next;
            Console.WriteLine("{0} Poped from stack", deleteNode);
        }
        public void IsEmpty()// to pop all the elements from stack untill stack is empty.

        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (top != null)
            {
                Pop();
            }
            Console.WriteLine("All element Poped from Stack!");
        }
    }
}
    


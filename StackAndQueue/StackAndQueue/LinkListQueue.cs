using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
     class LinkListQueue
    {
        
        private Node front;
        public void Enqueue(int value)// to Enqueue the value.

        {
            Node node = new Node(value);
            if (this.front == null)
                this.front = node;
            else
            {
                Node rear = front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;
            }
            Console.WriteLine("{0} Enqueued into Queue", value);
        }
        public void Display()// to display the elements of Queue.

        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine("Element in Queue:" + temp.data);
                    temp = temp.next;
                }
            }
        }
       
        
    }
}
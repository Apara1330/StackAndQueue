using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Stack and Queue using Linked List");
            CallStackQueue();
            Console.ReadLine();
        }
        public static void CallStackQueue()
        {
            LinkListStack linkedListStack = new LinkListStack();
            LinkListQueue linkedListQueue = new LinkListQueue();

          bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("\nEnter your option!");
                Console.WriteLine("1 for Stack , 2 for Queue, 3 for Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Creating a Stack");
                        linkedListStack.Push(70);
                        linkedListStack.Push(30);
                        linkedListStack.Push(56);
                        linkedListStack.Display();
                        Console.WriteLine("\nPeakOperation\n");
                        linkedListStack.Peak();
                        linkedListStack.Display();
                        Console.WriteLine("\nPopOperation\n");
                        linkedListStack.Pop();
                        linkedListStack.Display();
                        Console.WriteLine("\nPopTillStackBecomesEmpty\n");
                        linkedListStack.IsEmpty();
                        linkedListStack.Display();
                        break;
                    case 2:
                        Console.WriteLine("\nCreating a Queue\n");
                        linkedListQueue.Enqueue(56);
                        linkedListQueue.Enqueue(30);
                        linkedListQueue.Enqueue(70);
                        linkedListQueue.Display();
                        break;
                    case 3:
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct option!");
                        break;
                }
            }
        }
    }
}
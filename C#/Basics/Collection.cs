using System;

namespace Basics
{
    internal class Collection
    {
        static void main(string[] args)
        {
            //List
            var lst = new List<string>();
            lst.Add("MSD");
            lst.Add("VK");
            lst.Add("ABD");
            foreach (var i in lst)
            {
                Console.WriteLine(i+ " ");
            }
            Console.WriteLine("List Demo");
            var listDemo = new List<string>() { "new", "oranges" };
            listDemo.Add("Hello");
            listDemo.Add("Hello1");
            listDemo.Add("Hello2");
            listDemo.Add("Hello3");
            listDemo.Add("Hello3");
            foreach (var item in listDemo)
            {
                Console.WriteLine(item);
            }
            listDemo.Remove("Hello1");

            Console.WriteLine("\nAfter Removal");
            foreach (var item in listDemo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nStack");
            Stack<string> stack1 = new Stack<string>();
            stack1.Push("A");
            stack1.Push("B");
            stack1.Push("C");

            string peekvalue;
            while (stack1.Count != 0)
            {
                Console.Write(stack1.Pop() + " | ");
                if (stack1.TryPeek(out peekvalue))
                {
                    Console.WriteLine($"Peak element : {peekvalue}");
                }
            }

            Console.WriteLine("\nQueue");

            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("A");
            queue1.Enqueue("B");
            queue1.Enqueue("C");
            queue1.Enqueue("B");


            while (queue1.Count != 0)
            {
                Console.WriteLine(queue1.Dequeue() + " | ");

            }
            Console.WriteLine("Linked List");
            LinkedList<int> llst = new LinkedList<int>();
            llst.AddLast(2);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Welocome to Stack & Queue Programs Using Linked list *****");

            Queue obj = new Queue();
            Console.WriteLine("After push the elements are : ");

            obj.enqueue(56);
            obj.enqueue(30);
            obj.enqueue(70);
            Console.WriteLine();
            Console.WriteLine("Item popped from Queue = " + obj.dequeue());


            Console.WriteLine("Top Element of the Queue is : " + obj.peek());

            //We can check other functios:


            //Console.WriteLine();
            //Console.WriteLine("size : " + obj.size());
            //Console.WriteLine("peek : " + obj.peek());
            //Console.WriteLine("dequeue : " + obj.dequeue());
            //Console.WriteLine("size : " + obj.size());
            //Console.WriteLine("peek : " + obj.peek());
            //Console.WriteLine("isEmpty : " + obj.isEmpty());

        }
    }
}
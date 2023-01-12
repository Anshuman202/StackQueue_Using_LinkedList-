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

            Stack obj = new Stack();
            Console.WriteLine("After push the elements are : ");

            obj.push(70);
            obj.push(30);
            obj.push(56);
            Console.WriteLine();

            Console.WriteLine("Top Element of the stack is : " + obj.peek());

        }
    }
}



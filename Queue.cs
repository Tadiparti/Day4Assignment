using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    class Queue
    {
        static void Main(string[] args)
        {
            var value = new Queue<string>();

            value.Equals(1);
            value.Equals(2);
            value.Equals(3);
            value.Equals(4);
            Console.WriteLine(value.ToString());
            Console.WriteLine(value.Peek());
            Console.WriteLine();
            foreach (string num in value) 
            { 
                Console.WriteLine(num);
                Console.ReadLine();
            }
        }
        
            
    }
}

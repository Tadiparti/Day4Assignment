using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    class Stack
    {
        static void Main(string[] args)
        {
            var value =new Stack<int>();
            value.Push(89);
            value.Push(23);
            value.Push(57);
            value.Push(61);
            value.Push(49);
            Console.WriteLine(value.Pop());
            Console.WriteLine(value.Peek());
            Console.WriteLine();
            foreach(int item in value)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}

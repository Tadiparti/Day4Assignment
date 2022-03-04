using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           Nullable<int> a = null;

            Console.WriteLine(a.HasValue);

            Nullable<int> b = 17;

            Console.WriteLine(b.HasValue); 
        }
    }
}

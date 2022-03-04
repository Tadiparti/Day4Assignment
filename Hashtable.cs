using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Text;


namespace Day4Assignment
{
    class Hashtable
    {
        static void Main(string[] args)
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "T");
            HT.Add(2, "S");
            HT.Add(3, "A");
            HT.Add(4, "I");
             foreach (object i in HT.Keys)
                Console.WriteLine(i);
             foreach(object j in HT.Values)
                Console.WriteLine(j);
            Console.ReadKey();
        }

    }
}

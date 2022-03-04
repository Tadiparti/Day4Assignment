using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    class Dictionary
    {
        static public void Main(string[] args)
        {
            Dictionary<int, string>My_dict1 = new Dictionary<int, string>();

            My_dict1.Add(1234, "Welcome");
            My_dict1.Add(5678, "to");
            My_dict1.Add(0864, "IBM");
            foreach(KeyValuePair<int, string> kvp in My_dict1)
            {
                Console.WriteLine("{0} and {1}",kvp.Key,kvp.Value);
            }
            Console.WriteLine();
        }

    }
}

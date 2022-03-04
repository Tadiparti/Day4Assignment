using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Day4Assignment
{
    class Bitarray
    {
        BitArray myBitArr = new BitArray(6);

        myBitArr[0] = false;
        myBitArr[1] = true;
        myBitArr[2] = true;
        myBitArr[3] = false;
        myBitArr[4] = true;
        myBitArr[5] = false;
            //To get the value of index at index 3
        Console.WriteLine(myBitArr.Get(3));
           //To get the value of index at index 4
        Console.WriteLine(myBitArr.Get(4));
    }
}

using System;

namespace Lesson3;
class Program
{
    static void Main(string[] args)
    {
        int x = 3;
        int y = 1;

        y++ ;   //adds 1
        y += 2; //adds 2
        y /= 2; //divides by 2
        y *= 2; //multiples by 2

        //Logical Operators

        bool b1 = 5 > 2 && 5 > 3;   //returns true
        bool b2 = 5 < 2 && 5 > 3;   //returns false
        bool b3 = 5 < 2 || 5 > 3;   //return true
        bool b4 = 5 > 2 && ! b2;    //returs true

    }
}

using System;

namespace Lesson2;
class Program
{
    static void Main(string[] args)
    {

        byte b = 5;         //1 byte
        sbyte sb = 5;       //1 byte

        short s = 5;        //2 byte
        ushort us = 5;      //2 byte

        Int16 i16 = 5;      //2 byte
        int i = 5;          //4 byte
        Int32 i32 = 5;      //4 byte
        Int64 i64 = 5;      //8 byte

        uint ui = 5;        //4 byte
        long l = 5;         //8 byte
        ulong ul = 5;       //8 byte

        float f = 5.2f;      //4 byte
        double d = 5.2;     //8 byte
        decimal de = 5.2m;   //16 byte

        char c = '5';       //2 byte
        string str = "5";     //Unlimited

        bool bl = true;

        DateTime dt = DateTime.Now;

        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 'y';
        object o3 = 5;
        object o4 = 5.2;

        string str1 = string.Empty;
        str1 = "Patika";
        string name = "John";
        string surname = "Smith";
        string fullname = name + " " + surname;

        int int1 = 5;
        int int2 = 5;
        int int3 = int1 * int2 ;

        bool bl1 = 5 > 2 ;  //returns true
        bool bl2 = 5 < 2 ;  //returns false

        //type conversion

        string str20 = "20";
        int int20 = 20;

        string cvn1 = str20 + int20.ToString();     //output is 2020
        int cvn2 = Convert.ToInt32(str20) + int20;  //output is 40
        int cvn3 = int20 + int.Parse(str20);        //output is 40

        //datetime

        string date = DateTime.Now.ToString("dd.MM.yyyy"); //to stringify date
        string time = DateTime.Now.ToString("HH:mm");      //to stringify time


    }
}

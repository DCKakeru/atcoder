using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var b = Console.ReadLine();
        if (string.IsNullOrEmpty(b))
        {
            Console.WriteLine("bを入力してください");
            return;
        }

        if (!(b == "A" || b == "T" || b == "C" || b == "G"))
        {
            Console.WriteLine("A,T,C,Gのいずれかを入力してください");
            return;
        }

        if (b == "A")
        {
            Console.WriteLine("T");
            return;
        }
        if (b == "T")
        {
            Console.WriteLine("A");
            return;
        }
        if (b == "C")
        {
            Console.WriteLine("G");
            return;
        }
        if (b == "G")
        {
            Console.WriteLine("C");
            return;
        }
    }
}

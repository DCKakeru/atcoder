using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if(string.IsNullOrEmpty(input))
        {
            Console.WriteLine("入力がありません");
            return;
        }

        var inputLen = input.Length;
        var rep = input.Select((i, index) => {
            var s1 = input.Substring(0, index);
            var s2 = input.Substring(index, inputLen - index);
            return s2 + s1;
        });
        Console.WriteLine(rep.Min());
        Console.WriteLine(rep.Max());
    }
}

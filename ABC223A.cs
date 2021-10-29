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

        if(!int.TryParse(input, out int i))
        {
            Console.WriteLine("整数値を入力してください");
            return;
        }
            var x = int.Parse(input);
            Console.WriteLine((x >= 100 && x % 100 == 0) ? "Yes" : "No");

    }
}

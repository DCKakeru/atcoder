using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        

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
        
        Console.WriteLine("{0:d4}",int.Parse(input));
    }
}

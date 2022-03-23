using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("入力がありません");
            return;
        }
        if (input.Split(" ").Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("H,Wを整数値で入力してください");
            return;
        }
        var h = int.Parse(input.Split(" ")[0]);
        var w = int.Parse(input.Split(" ")[1]);

        var inputBlack = Console.ReadLine();
        if (inputBlack.Split(" ").Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("h,wを整数値で入力してください");
            return;
        }
        var hBlack = int.Parse(inputBlack.Split(" ")[0]);
        var wBlack = int.Parse(inputBlack.Split(" ")[1]);

        Console.WriteLine((h - hBlack) * (w - wBlack));
    }
}

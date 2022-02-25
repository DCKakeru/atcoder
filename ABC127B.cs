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
        var inputRDX = input.Split(" ");


        if (inputRDX.Length != 3)
        {
            Console.WriteLine("r,D,xを空白区切りで入力してください");
            return;
        }
        if (inputRDX.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("r,D,xを整数値で入力してください");
            return;
        }

        var r = int.Parse(inputRDX[0]);
        var d = int.Parse(inputRDX[1]);
        var x = int.Parse(inputRDX[2]);

        var ans = Enumerable.Range(0, 10).Aggregate(x, (culc, i) =>
        {
            Console.WriteLine(culc * r - d);
            return culc * r - d;
        });
    }
}

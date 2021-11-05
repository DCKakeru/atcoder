using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        var inputAB = input.Split(" ");
        
        if(inputAB.Length != 2)
        {
            Console.WriteLine("A,Bを空白区切りで入力してください");
            return;
        }
        if(inputAB.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("A,Bを整数値で入力してください");
            return;
        }

        var a = int.Parse(inputAB[0]);
        var b = int.Parse(inputAB[1]);

        if(a == b){
            Console.WriteLine("{0}", 2 * a);
            return;
        }
        Console.WriteLine("{0}",2 * Math.Max(a, b) - 1);
    }
}

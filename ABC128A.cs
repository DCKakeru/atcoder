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
        var inputAP = input.Split(" ");

        if (inputAP.Length != 2)
        {
            Console.WriteLine("A,Pを空白区切りで入力してください");
            return;
        }
        if (inputAP.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("A,Pを整数値で入力してください");
            return;
        }

        var a = int.Parse(inputAP[0]);
        var p = int.Parse(inputAP[1]);

        Console.WriteLine((3 * a + p) / 2);
    }
}

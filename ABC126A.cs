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

        var inputNK = input.Split(" ");
        if(inputNK.Length != 2)
        {
            Console.WriteLine("N,Kを空白区切りで指定数入力してください");
            return;
        }
        if(inputNK.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("N,Kを整数値で入力してください");
            return;
        }
        var n = int.Parse(inputNK[0]);
        var k = int.Parse(inputNK[1]);

        var s = Console.ReadLine();

        if(string.IsNullOrEmpty(s))
        {
            Console.WriteLine("文字列を入力してください");
            return;
        }

        var sArr = s.ToCharArray();
        sArr[k - 1] = char.ToLower(sArr[k - 1]);
        Console.WriteLine(sArr.Aggregate("",(ans, n) => ans + n.ToString()));
    }
}
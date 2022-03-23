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
            Console.WriteLine("N,M,Cを整数値で入力してください");
            return;
        }
        var n = int.Parse(input.Split(" ")[0]);
        var c = int.Parse(input.Split(" ")[2]);

        var inputB = Console.ReadLine();
        if (inputB.Split(" ").Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("Bを整数値で入力してください");
            return;
        }
        var bList = inputB.Split(" ").Select(i => int.Parse(i)).ToList();

        var inputA = Enumerable.Range(0, n).Select(i => Console.ReadLine().Split(" ")).ToList();
        if (inputA.Any(item => item.Any(aItem => !int.TryParse(aItem, out int i))))
        {
            Console.WriteLine("Aを整数値で入力してください");
            return;
        }
        var aList = inputA.Select(item => item.Select(aItem => int.Parse(aItem)));

        var ans = aList.Select(item => item.Select((aItem, idx) => aItem * bList[idx]).Sum()).Count(item => item + c > 0);
        Console.WriteLine(ans);
    }
}

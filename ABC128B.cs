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

        if (!int.TryParse(input, out int i))
        {
            Console.WriteLine("Nを整数値で入力してください");
        }

        var n = int.Parse(input);

        var inputSP = Enumerable.Range(1, n).Select(i => Console.ReadLine()).ToArray();

        if (inputSP.Any(i => string.IsNullOrEmpty(i)))
        {
            Console.WriteLine("入力が不足しています");
            return;
        }
        var inputList = inputSP.Select(i => i.Split(" ").ToList()).ToList();
        if (inputList.Any(i => !int.TryParse(i[1], out int j)))
        {
            Console.WriteLine("Pを整数値で入力してください");
            return;
        }
        inputList = inputList.Select((i, index) =>
        {
            i.Add(index.ToString());
            return i;
        }).ToList();
        var ans = inputList.OrderByDescending(i => int.Parse(i[1])).OrderBy(j => j[0]).Select(k =>
        {
            return int.Parse(k[2]) + 1;
        }).ToList();
        ans.ForEach(x => Console.WriteLine(x));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var antennas = Enumerable.Range(1, 5).Select(i =>
        {
            var tmp = Console.ReadLine();
            if (string.IsNullOrEmpty(tmp)) return -1;
            if (!int.TryParse(tmp, out int res)) return -2;
            return int.Parse(tmp);
        }).ToArray();
        if (antennas.Any(item => item == -1))
        {
            Console.WriteLine("入力が不足しています");
            return;
        }
        if (antennas.Any(item => item == -2))
        {
            Console.WriteLine("0以上123以下の整数値を入力してください");
            return;
        }

        var kInput = Console.ReadLine();
        if (string.IsNullOrEmpty(kInput))
        {
            Console.WriteLine("kを入力してください");
            return;
        }
        if (!int.TryParse(kInput, out int i))
        {
            Console.WriteLine("kに整数値を入力してください");
            return;
        }
        var k = int.Parse(kInput);

        var ans = antennas.Select((item, index) =>
        {
            if (index == 4) return 0;
            var tmp = Enumerable.Range(index + 1, 4 - index).Select(next => Math.Abs(item - antennas[next])).Max();
            return tmp;
        }).Max();
        Console.WriteLine((ans <= k) ? "Yay!" : ":(");
    }
}

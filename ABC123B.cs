using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var times = Enumerable.Range(1, 5).Select(i =>
        {
            var tmp = Console.ReadLine();
            if (string.IsNullOrEmpty(tmp)) return -1;
            if (!int.TryParse(tmp, out int res)) return -2;
            return int.Parse(tmp);
        }).ToArray();
        if (times.Any(item => item == -1))
        {
            Console.WriteLine("入力が不足しています");
            return;
        }
        if (times.Any(item => item == -1))
        {
            Console.WriteLine("1以上123以下の整数値を入力してください");
            return;
        }
        
        var waitTime = times.Select(item => {
            var rem = (item - 1) % 10 + 1;
            return item + 10 -rem;
        }).Sum();
        var additionalTime = times.Select(item => (item - 1) % 10 + 1).Min();
        Console.WriteLine(waitTime + additionalTime - 10);
    }
}

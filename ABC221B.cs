using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string v = Console.ReadLine();
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(v))
        {
            Console.WriteLine("入力がありません");
            return;
        }
        if(s.Equals(v)) {
            Console.WriteLine("Yes");
            return;
        }

        int sLen = s.Length;
        var sRep = s.Select((i, index) => {
            var s1 = s.Substring(0, index);
            var sRep1 = s.Substring(index, 1);
            var sRep2 = (index == sLen - 1) ? "" : s.Substring(index + 1, 1);
            var s4 = (index >= sLen - 2) ? "" : s.Substring(index + 2);
            return s1 + sRep2 + sRep1 + s4;
        }).Where(x => x.Equals(v)).ToList();

        Console.WriteLine((sRep.Count == 0) ? "No" : "Yes");
    }
}
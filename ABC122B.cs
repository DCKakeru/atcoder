using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine();
        if (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("sを入力してください");
            return;
        }

        var maxACGTLength = s.Select((i, idx) =>
        {
            if (!(i == 'A' || i == 'C' || i == 'G' || i == 'T')) return "";
            var ans = "";
            return IsNextACGT(s.Substring(idx, s.Length - idx), ans);
        }).Select(i => i.Length).Max();
        Console.WriteLine(maxACGTLength);
    }
    public string IsNextACGT(string s, string ans)
    {
        ans = ans + s.Substring(0, 1);
        if (s.Length == 1) return ans;
        if (s[1] == 'A' || s[1] == 'C' || s[1] == 'G' || s[1] == 'T')
        {
            ans = IsNextACGT(s.Substring(1, s.Length - 1), ans);
        }
        return ans;
    }
}

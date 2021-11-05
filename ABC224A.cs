using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        if(string.IsNullOrEmpty(s))
        {
            Console.WriteLine("入力がありません");
            return;
        }

        /*
        var sLen = s.Length;
        if(sLen < 2)
        {
            Console.WriteLine("2文字以上入力してください");
            return;
        }
        if(!s.Substring(sLen - 2).Equals("er") && (s.Length >= 3 ? !s.Substring(sLen - 3).Equals("ist") : true))
        {
            Console.WriteLine("erまたはistで終わる文字を入力してください");
            return;
        }
        Console.WriteLine(s.Substring(sLen - 2).Equals("er") ? "er" : "ist");
        */

        var rgxEr = new Regex(@"er$");
        var rgxIst = new Regex(@"ist$");

        if(!rgxEr.IsMatch(s) && !rgxIst.IsMatch(s))
        {
            Console.WriteLine("erまたはistで終わる文字を入力してください");
            return;
        };

        Console.WriteLine(rgxEr.IsMatch(s) ? "er" : "ist");       
    }
}

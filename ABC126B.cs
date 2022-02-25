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
        if(!int.TryParse(input, out int i) || input.Length != 4)
        {
            Console.WriteLine("4桁の整数を入力してください");
            return;
        }

        var sList = new List<int> {int.Parse(input.Substring(0,2)), int.Parse(input.Substring(2,2))};
        //右辺が明確な場合、わざわざ型指定するのは冗長

        var isCanMonth = sList.Select(i => (i <= 12 && i >= 1) ? 1 : 0).ToArray();

        if(Convert.ToBoolean(isCanMonth[0])){
            Console.WriteLine(Convert.ToBoolean(isCanMonth[1]) ? "AMBIGUOUS" : "MMYY");
        }else{
            Console.WriteLine(Convert.ToBoolean(isCanMonth[1]) ? "YYMM" : "NA");
        }
    }
}

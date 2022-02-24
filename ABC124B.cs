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
        if(!int.TryParse(input, out int i))
        {
            Console.WriteLine("Nを整数値で入力してください");
            return;
        }

        var n = int.Parse(input);
        var inputH = Console.ReadLine();

        if(string.IsNullOrEmpty(inputH))
        {
            Console.WriteLine("入力が不足しています");
            return;
        }

        var inputHArr = inputH.Split(" ");
        if(inputHArr.Length != n)
        {
            Console.WriteLine("Hを空白区切りで指定数入力してください");
            return;
        }
        if(inputHArr.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("Hを整数値で入力してください");
            return;
        }

        var inputHInt = inputHArr.Select(i => int.Parse(i));

        var ans = inputHInt.Aggregate((int.MinValue, 0),(highestTuple, i) => {
                if (i < highestTuple.Item1){
                    return highestTuple;
                }
                return (i, highestTuple.Item2 + 1);
            });
        Console.WriteLine(ans.Item2);
    }
}

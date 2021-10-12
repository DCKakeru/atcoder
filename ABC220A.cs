using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if(string.IsNullOrEmpty(input))
        {
            Console.WriteLine("入力がありません");
            return;
        }

        var inputArr = input.Split(" ");

        if(inputArr.Length != 3)
        {
            Console.WriteLine("数値を空白区切りで入力してください");
            return;
        }

        if(inputArr.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("整数値を入力してください");
            return;
        }

        var ans = int.Parse(inputArr[2]);

        while (ans < int.Parse(inputArr[0])){
            ans += int.Parse(inputArr[2]);
        }
        Console.WriteLine((ans <= int.Parse(inputArr[1])) ? ans : -1);
    }
}

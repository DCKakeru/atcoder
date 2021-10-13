using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var inputK = Console.ReadLine();
        var inputAB = Console.ReadLine();

        if(string.IsNullOrEmpty(inputK)||string.IsNullOrEmpty(inputAB))
        {
            Console.WriteLine("入力が不足しています");
            return;
        }
        var inputArr = inputAB.Split(" ");
        
        if(inputArr.Length != 2)
        {
            Console.WriteLine("数値を空白区切りで入力してください");
            return;
        }

        if(!int.TryParse(inputK, out int i) || inputArr.Any(item => !long.TryParse(item, out long i)))//10^5をn進数で表示 => 2^16.6なので17桁必要 = long型
        {
            Console.WriteLine("整数値を入力してください");
            return;
        }

        var k = int.Parse(inputK);

        var a10 = inputArr[0].Select((i,index) => {
            var num = int.Parse(inputArr[0].Substring(index,1));//string != charの集合体 => 部分文字列の生成が必要
            return num * Math.Pow(k , inputArr[0].Length - index - 1);
        }).Sum();

        var b10 = inputArr[1].Select((i,index) => {
            var num = int.Parse(inputArr[1].Substring(index,1));
            return num * Math.Pow(k , inputArr[1].Length - index - 1);
        }).Sum();

        Console.WriteLine(a10 * b10);
    }
}

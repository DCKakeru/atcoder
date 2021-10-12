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

        if(!int.TryParse(inputK, out int i) || inputArr.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("整数値を入力してください");
            return;
        }

        Console.WriteLine(inputArr[0].Select((i,index) => {
            var num = int.Parse(inputArr[0].Substring(index,1));//int.Parse(i)ではエラー
            return num * Math.Pow(int.Parse(inputK) , inputArr[0].Length - index - 1);
        }).Sum()
        * inputArr[1].Select((i,index) => {
            var num = int.Parse(inputArr[1].Substring(index,1));//int.Parse(i)ではエラー
            return num * Math.Pow(int.Parse(inputK) , inputArr[1].Length - index - 1);
        }).Sum());
    }
}//なぜか一つテストケース通らない

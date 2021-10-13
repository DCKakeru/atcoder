using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var inputNP = Console.ReadLine();
        var inputA = Console.ReadLine();

        if(string.IsNullOrEmpty(inputNP)||string.IsNullOrEmpty(inputA))
        {
            Console.WriteLine("入力が不足しています");
            return;
        }
        var inputArrNP = inputNP.Split(" ");
        var inputArrA = inputA.Split(" ");
        
        if(inputArrNP.Length != 2)
        {
            Console.WriteLine("N,Pを空白区切りで入力してください");
            return;
        }

        if(inputArrNP.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("N,Pに整数値を入力してください");
            return;
        }

        var n = int.Parse(inputArrNP[0]);
 
        if(inputArrA.Length != n)
        {
            Console.WriteLine("aを空白区切りで指定数だけ入力してください");
            return;
        }

        if(inputArrA.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("aに整数値を入力してください");
            return;
        }

        Console.WriteLine(inputArrA.Where(item => int.Parse(item) < int.Parse(inputArrNP[1])).Count());
    }
}

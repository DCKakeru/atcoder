using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtCoder
{
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
            var inputABT = input.Split(" ");
        
            if(inputABT.Length != 3)
            {
                Console.WriteLine("A,B,Tを空白区切りで入力してください");
                return;
            }
            if(inputABT.Any(item => !int.TryParse(item, out int i)))
            {
                Console.WriteLine("A,B,Tを整数値で入力してください");
                return;
            }
            var a = int.Parse(inputABT[0]);
            var b = int.Parse(inputABT[1]);
            var t = int.Parse(inputABT[2]);

            Console.WriteLine(t / a * b);
        }
    }
}
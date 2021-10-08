using System;
using System.Collections.Generic;
using System.Linq;

namespace DIVA_INTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("入力なし");
                return;
            }

            string[] inputArr = input.Split(" ");

            if(inputArr.Length != 2)
            {
                Console.WriteLine("空白区切りで入力してください");
                return;
            }

            if(inputArr.Any(item => !int.TryParse(item, out int i)))
            {
                Console.WriteLine("整数値を入力してください");
                return;
            }

            Console.WriteLine(Math.Pow(32, int.Parse(inputArr[0]) - int.Parse(inputArr[1])));
        }
    }
}

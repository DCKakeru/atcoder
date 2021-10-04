using System;

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

            if(!int.TryParse(inputArr[0],out int a) || !int.TryParse(inputArr[1],out int b))
            {
                Console.WriteLine("整数値を入力してください");
                return;
            }

            Console.WriteLine(Math.Pow(32, a - b));
        }
    }
}

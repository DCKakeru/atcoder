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
            if(!int.TryParse(input, out int i))
            {
                Console.WriteLine("aを整数値で入力してください");
                return;
            }
            var a = int.Parse(input);

            input = Console.ReadLine();
            var inputV = input.Split(" ");
            if(inputV.Length != a)
            {
                Console.WriteLine("Vを空白区切りで入力してください");
                return;
            }
            if(inputV.Any(item => !int.TryParse(item, out int i)))
            {
                Console.WriteLine("Vを整数値で入力してください");
                return;
            }
            var inputVInt = inputV.Select(i => int.Parse(i)).ToList();

            input = Console.ReadLine();
            var inputC = input.Split(" ");
            if(inputC.Length != a)
            {
                Console.WriteLine("Cを空白区切りで入力してください");
                return;
            }
            if(inputC.Any(item => !int.TryParse(item, out int i)))
            {
                Console.WriteLine("Cを整数値で入力してください");
                return;
            }
            var inputCInt = inputC.Select(i => int.Parse(i)).ToList();

            Console.WriteLine(inputVInt.Select((item, i)=>{
                return (item > inputCInt[i]) ? item - inputCInt[i] : 0;
                }).Sum());
        }
    }
}
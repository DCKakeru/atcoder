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

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("入力がありません");
                return;
            }
            var inputHW = input.Split(" ");

            if (inputHW.Length != 2)
            {
                Console.WriteLine("H,Wを空白区切りで入力してください");
                return;
            }
            if (inputHW.Any(item => !int.TryParse(item, out int i)))
            {
                Console.WriteLine("H,Wを整数値で入力してください");
                return;
            }

            var h = int.Parse(inputHW[0]);
            var w = int.Parse(inputHW[1]);

            var inputA = Enumerable.Range(1, h).Select(i => Console.ReadLine()).ToArray();
            if (inputA.Any(i => string.IsNullOrEmpty(i)))
            {
                Console.WriteLine("入力が不足しています");
                return;
            }

            var inputList = inputA.Select(i => i.Split(" ").ToList()).ToList();

            // IList<IList<string>>
            // foreach(var i in inputList){
            //     if(i.Any(item => !int.TryParse(item, out int j))){
            //         Console.WriteLine("整数値を入力してください");
            //         return;
            //     }
            // }
            var isAllNum = !inputList.Any(inner =>
            {
                return inner.Any(i => !int.TryParse(i, out int j));
            });

            if (!isAllNum)
            {
                Console.WriteLine("整数値を入力してください");
                return;
            }

            //Console.WriteLine(int.Parse(inputList[0][0]));
            var inputListInt = inputList.Select(iItem =>
            {
                return iItem.Select(jItem => int.Parse(jItem)).ToList();   
            }).ToList();

            var isFill = Enumerable.Range(0, h - 1).Any(i => 
            {
                return !Enumerable.Range(1, h - i - 1).Any(k => 
                {
                    var tmp = -Math.Pow(10, 10);
                    return Enumerable.Range(0, w).Any(j => {    
                        if(tmp <= inputListInt[i][j] - inputListInt[i+k][j])
                        {
                            tmp = inputListInt[i][j] - inputListInt[i+k][j];
                        }else
                        {
                            return true;
                        }
                        return false;
                    });
                });
            });

            Console.WriteLine(isFill ? "Yes" : "No");
        }
    }
}
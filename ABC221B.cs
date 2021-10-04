using System;

namespace DIVA_INTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string v = Console.ReadLine();

            if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(v))
            {
                Console.WriteLine("入力がありません");
                return;
            }

            if(s.Equals(v)) {
                Console.WriteLine("Yes");
                return;
            }

            int sLen = s.Length;
            string s1,sRep1,sRep2,s4,stmp;
            for (var i = 0; i < sLen - 1; i++)
            {
                s1 = s.Substring(0, i);
                sRep1 = s.Substring(i, 1);
                sRep2 = s.Substring(i+1, 1);
                if(i == sLen-2)
                {
                    s4 = "";
                }else
                {
                    s4 = s.Substring(i+2);
                }
                
                stmp = s1 + sRep2 + sRep1 + s4;
                
                if(stmp.Equals(v)) 
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
        }
    }
}

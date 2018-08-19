using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProgs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Fibonacci1(10);
            //Fibonacci2(0, 1, 1, 10);
            //PrintSquare(5);
            //PrintTriangle1(5);
            //PrintTriangle2(8);
            //RomanToNumeric("MDM");
        }


        public static void Fibonacci1(int num)
        {
            int a = 1,
                b = 1,
                c = 0;

            Console.Write("{0} ", a);

            for(int i=0; i<=num; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.Write("{0} ", c);
            }
            Console.WriteLine();
        }

        public static void Fibonacci2(int a, int b, int c, int d)
        {
            if(c <= d)
            {
                Console.Write("{0} ", a);
                Fibonacci2(b, a + b, c + 1, d);
            }
        }

        public static void PrintSquare(int num)
        {
            for(int row=0; row<=num-1; row++)
            {
                for(int column=0; column<=num-1; column++)
                {
                    if(column > 0 && column < num-1)
                    {
                        if (row > 0 && row < num-1) Console.Write(" ");
                        else Console.Write("*");
                    }
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangle1(int num)
        {
            string p = string.Empty;
            for(int i=0; i<num; i++)
            {
                Console.WriteLine(p += "*");
            }
        }

        public static void PrintTriangle2(int num)
        {
            double space = num % 2 == 0 ? (num / 2) : (num / 2) + 0.5;
            string p = string.Empty;
            for (int a = 0; a < num; ++a)
            {
                for (double b = 0.5; b < space; b += 0.5)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(p += "*");
                space -= 0.5;
            }

        }

        public static void RomanToNumeric(string roman)
        {
            char[] ar = roman.ToCharArray();
            int result = 0,
                value1 = 0,
                value2 = 0;
            IDictionary<char, int> d = new Dictionary<char, int>()
            {
                {'M', 1000 },
                {'D', 500 },
                {'C', 100 },
                {'L', 50 },
                {'X', 10 },
                {'V', 5 },
                {'I', 1 },
            };
            
            for(int i=0; i<=ar.Length-1; i++)
            {
                try
                {
                    d.TryGetValue(ar[i], out value1);
                    d.TryGetValue(ar[i + 1], out value2);

                    result += value1 >= value2 ? value1 : -value1;
                }
                catch
                {
                    result += value1;
                }

                Console.WriteLine(result);
            }
            
        }
    }
}

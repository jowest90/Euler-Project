/*
Project-Euler C#
Author: John West
Desc: solving all Euler problems in C#
 */
using System;

namespace Project_Euler_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            p001 p1 = new p001();
            Console.WriteLine("Problem 1: "+p1.run());

            p021 p21 = new p021();
            Console.WriteLine("Problem 21: " + p21.run());
        }

        static void isAmicable(int a){
            int b = divisorSum(a);
            Console.WriteLine("d(" + a + ") = " + b);
            a = divisorSum(b);
            Console.WriteLine("d(" + b + ") = " + a);

            if (b != a && divisorSum(a) == b)
            {
                Console.WriteLine(a + " and " + b + " are an amicable pair");
            }
            else
            {
                Console.WriteLine(a + " and " + b + " are NOT an amicable pair");
            }
        }

        static int divisorSum(int n){
            int a=0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    a += i;
                }
            }

            return a;
        }
    }
}

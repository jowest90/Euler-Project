using System;

namespace Project_Euler_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = Convert.ToInt32(Console.ReadLine());
        }

        public static void isAmicable(int a){
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

        public static int divisorSum(int n){
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

/*
Solution for Problem 21
 */
using System;

namespace Project_Euler_C_{
    class p021{
        public string run(){
            int sum = 0;
            for (int i = 1; i < 10000; i++)
            {
                if (isAmicable(i))
                    sum += i;
            }
            return sum.ToString();
        }
        private static Boolean isAmicable(int n){
            int m = divisorSum(n);
            return m != n && divisorSum(m) == n;
        }

        private static int divisorSum(int n){
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
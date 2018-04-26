/*
Solution for Problem 1
 */
using System;

namespace Project_Euler_C_{
    class p001{
        public String run(){
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum.ToString();
        }
    }
}
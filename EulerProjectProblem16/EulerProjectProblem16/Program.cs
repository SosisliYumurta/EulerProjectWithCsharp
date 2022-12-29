using System;
using System.Numerics;

namespace EulerProjectProblem16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = 1;
            int result = 0;
            for (int i = 1; i <= 1000; i++)
            {
                num *= 2;
            }
            Console.WriteLine(num);
            while (num > 0)
            {
                result += (int)(num % 10);
                num /= 10;
            }
            Console.WriteLine(result);
        }
    }
}

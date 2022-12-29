using System;
using System.Numerics;

namespace EulerProjectProblem20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger fact = 1;
            int tmp = 0, result = 0;
            for (int i = 1; i <= 100; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);

            while (fact > 0)
            {
                result += (int)(fact % 10);
                fact /= 10;

            }
            Console.WriteLine(result);
        }
    }
}

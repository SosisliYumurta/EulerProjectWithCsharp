using System;

namespace EulerProjectProblem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i * i;
                sum2 += i;
            }
            sum2 = sum2 * sum2;
            int result = sum2 - sum;
            Console.WriteLine(result);
        }
    }
}

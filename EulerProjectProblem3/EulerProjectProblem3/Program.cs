using System;

namespace EulerProjectProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;
            int k = 2;
            bool prime;
            while (true)
            {
                prime = true;
                for (int i = 2; i < k; i++)
                {
                    if(k % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    while (num > 0)
                    {
                        if (num % k == 0)
                        {
                            num /= k;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (num == 1)
                {
                    Console.WriteLine("biggest prime factor is "+k);
                    break;
                }

                k++;
            }
        }
    }
}

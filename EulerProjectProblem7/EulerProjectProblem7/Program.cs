using System;

namespace EulerProjectProblem7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int k = 3;
            int counter = 0;
             
            while (true)
            {
                prime = true;
                
                for (int i = 2; i < k / 2; i++)
                {
                    if (k % i == 0)
                    {
                        prime = false;
                        break;
                    }
                    
                   
                }
                if(prime)
                {
                    counter++;
                }
                if (counter == 10001)
                {
                    Console.WriteLine(k);
                    break;
                }
                k++;
            }
        }
    }
}

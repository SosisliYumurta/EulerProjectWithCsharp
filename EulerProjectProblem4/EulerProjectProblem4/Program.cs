using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int threeDigits1 = 999, threeDigits2 = 999;
            int bigger = 0;
            while (true)
            {
                if (IsPalindrome(threeDigits1 * threeDigits2))
                {
                    Console.WriteLine("{0} x {1} = {2} ", threeDigits1, threeDigits2, threeDigits1 * threeDigits2);
                }

                threeDigits2--;
                if (threeDigits2 < 100 && threeDigits1 < 100)
                    break;
                else if (threeDigits2 < 100)
                {
                    threeDigits2 = 999;
                    threeDigits1--;
                }
            }



            Console.ReadLine();
        }
        static public bool IsPalindrome(int check)
        {
            int temp = 0, sum = 0, newNumber = 0;
            temp = check;
            while (check > 0)
            {
                newNumber = check % 10;
                sum = (sum * 10) + newNumber;
                check /= 10;
            }
            if (sum == temp)
                return true;
            else
                return false;
        }
    }
}

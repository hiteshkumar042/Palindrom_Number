using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    internal class Reverse
    {
        public static void ReverseFunction(int number)
        {
            int rem, rev = 0;
            while (number != 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;

            }
            Console.WriteLine("Reverse Number is : " + rev);
        }
    }
}

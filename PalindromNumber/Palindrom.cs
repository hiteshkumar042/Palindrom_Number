using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    public class Palindrom
    {
        public static void PalindromFunction(int number)
        {
            int temp = number;
            int rem, rev = 0;
            
            while (temp != 0)
            {
                rem = temp % 10;
                rev = rev * 10 + rem;
                temp = temp / 10;

            }
            Console.WriteLine("Reverse Number is : " + rev);
            if (number == rev)
            {
                Console.WriteLine("Entered Number {0} is a Palindrom Number",number);
            }
            else
            {
                Console.WriteLine("Entered Number {0} is not a Palindrom Number",number);
            }
        }
    }
}

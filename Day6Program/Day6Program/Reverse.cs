using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    public class Reverse
    {
        public void ReverseNumber()
        {
            int n,rev=0,rem;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse No. is {0}", rev);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    public class Prefect
    {
        public void PrefectNumber()
        {
            int n, sum = 0, n1;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            for (int i = 1; i<= n; i++)
            {
                if(n%i ==0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n1)
            {
                Console.WriteLine("This is Perfect Number");
            }
            else
            {
                Console.WriteLine("This is not Perfect Number");
            }
        }
    }
}

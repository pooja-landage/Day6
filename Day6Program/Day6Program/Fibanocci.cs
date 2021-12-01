using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    public class Fibanocci
    {
        public void FibanocciNumber()
        {
            int n1 = 0, n2 = 1, n3, i, n;
            Console.WriteLine("Enter The number Of element");
            n = Convert.ToInt32(Console.ReadLine());

            //logic
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}

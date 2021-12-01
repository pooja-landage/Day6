using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    public class Binary
    {
        public void ConvertDecimal()
        {
            int n,a;
            string s;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            s = Console.ReadLine();
            while (n > 0)
            {
                a = n % 2;
                s = a + "" + s;
                n= n / 2;

            }
            Console.WriteLine("Binary Number :{0}",s);
            
        }
        public void ConvertBinary()
        {
            Console.Write("Enter the Binary Number : ");
            int BinN = Convert.ToInt32(Console.ReadLine());
            int decN = 0;
          
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (BinN > 0)
            {
                int reminder = BinN % 10;
                BinN = BinN / 10;
                decN += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write("Decimal Value : {0} ",decN);
            Console.ReadKey();
        }
    }
}

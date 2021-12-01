using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    public class Coupon
    {
        public static void ReadCoupons()
        {
            Console.WriteLine("Enter the distinct Coupsons");
            int coupon = Convert.ToInt32(Console.ReadLine());
           // FindNumber(coupon);
        }
        public void FindNumber(int n)
        {
            int n1 = n;
            int distinct = 0, count = 0;
            bool[] arr = new bool[n1];
        }
    }
}

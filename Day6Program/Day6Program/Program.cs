using System;
using Day6Program;

namespace Day6
{
    public class Program
    {
        static void Main(string[] args)
        {
            char s;
            do
            {
                Console.WriteLine("\t\t\t\t=====================List Of Basic Program==================");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t1.Fibanocci Number");
                Console.WriteLine("\t\t\t\t\t\t2.Perfect Number");
                Console.WriteLine("\t\t\t\t\t\t3.Prime Number");
                Console.WriteLine("\t\t\t\t\t\t4.Reverse iNumber");
                Console.WriteLine("\t\t\t\t\t\t5.Coupon");
                Console.WriteLine("\t\t\t\t\t\t6.StopWatch");
                Console.WriteLine("\t\t\t\t\t\t7.Vending Machine");
                Console.WriteLine("\t\t\t\t\t\t8.Decimal To Binary Conersion");
             //   Console.WriteLine("\t\t\t\t\t\t9.Alphabet is Vowel And Consonant");
             //   Console.WriteLine("\t\t\t\t\t\t10.Largest Among 3 number");

                Console.Write("\t\t\t\t\t\t ENTER YOUR CHOICE:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome To Fibanocci Number Program ");
                        Fibanocci fibanocci = new Fibanocci();
                        fibanocci.FibanocciNumber();
                        break;

                    case 2:
                        Console.WriteLine("Welcome to Perfect Number Program ");
                        Prefect prefect = new Prefect();
                        prefect.PrefectNumber();
                        break;

                    case 3:
                        Console.WriteLine("Welcome to Prime Number Program ");
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.Prime();
                        break;

                    case 4:
                        Console.WriteLine("Welcome to Reverse Number Program ");
                        Reverse reverse = new Reverse();
                        reverse.ReverseNumber();
                        break;

                    case 5:
                        Console.WriteLine("Welcome to Coupon Program ");
                        
                        break;

                    case 6:
                        Console.WriteLine("Welcome To StpWatch Program ");
                        StopwatchTime stopwatchTime = new StopwatchTime();
                        stopwatchTime.Time();
                        break;

                    case 7:
                        Console.WriteLine("Welcome To  Vending Machine Program ");
                       // Console.WriteLine("Enter the Amount in the Vending Machine");
                      //  int amount = Convert.ToInt32(Console.ReadLine());
                       // NoteChange(amount);
                       Vending vending = new Vending();
                        vending.NoteChange();
                        break;

                    case 8:
                        Console.WriteLine("Welcome To Decimal To Binary Conersion Program");
                        Binary binary = new Binary();
                        // binary.ConvertDecimal();
                        binary.ConvertBinary();
                        break;

                    case 9:
                        Console.WriteLine("Welcome to Alphabet is Vowel And Consonant");
                        
                        break;

                    case 10:
                        Console.WriteLine("Welcome to Largest Program ");
                     
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to continue press Y or N");
                s = Convert.ToChar(Console.ReadLine());

            } while (s != 'N');

           

        }
    }
}

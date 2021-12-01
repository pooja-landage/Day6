using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    public class Vending
    {
        public  void NoteChange()
        {
             
            int[] note = new int[] {  1000, 500, 100, 50,10,5,2,1 };
            int[] noteCount = new int[note.Length];

            Console.WriteLine("Note Present are :");
            foreach (int item in note)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine("Enter the Amount in the Vending Machine");
            int amount = Convert.ToInt32(Console.ReadLine());


            for (int i=0; i< note.Length; i++)
            {
                if(amount>=note[i]) //for comparing amount
                {
                    noteCount[i] = amount/note[i];   
                   // amount -=note[i];
                   amount = amount - (noteCount[i]*note[i]);
                }
            }

            Console.WriteLine("Note Count :");
            for(int i=0; i<note.Length; i++)
            {
                if(noteCount[i]!=0)
                {
                    Console.WriteLine("{0} : {1}",note[i],noteCount[i]);
                }
            }

            
            
        }
    }
}

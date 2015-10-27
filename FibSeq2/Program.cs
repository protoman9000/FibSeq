using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibSeq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor
            int tmp = 0;
            int tmp2 = 1;
            int seqNumber = 0;
            int startNumber = 0;

            //Number input
            Console.WriteLine("Enter in the desired integer:");
            string insertNumber = Console.ReadLine();
            int DInterger = Convert.ToInt16(insertNumber);

            //Creating a list to store the number sequence
            List<int> fibList = new List<int>();
            fibList.Insert(seqNumber, tmp);
            seqNumber++;
            int startNumber2 = tmp2;
            fibList.Insert(seqNumber, tmp2);
            seqNumber++;

            //The this is set up is by making startNumber as one, if it pass
            //the disired interger, we increase the startNumber. 
            for (int x = 0; x < DInterger; x++)
            {
                int insert = startNumber + startNumber2;
                if (insert <= DInterger)
                {
                    fibList.Insert(seqNumber, insert);
                    seqNumber++;
                    startNumber = startNumber2;
                    startNumber2 = insert;
                    if (insert == DInterger)
                    {
                        x = insert;
                    }
                }
                else
                {
                    //If the sequence fail, we try again by clearing out the list and increase startnumber2
                    //and restart the program. 
                    fibList.Clear();
                    seqNumber = 0;
                    fibList.Insert(seqNumber, tmp);
                    seqNumber++;
                    tmp2++;                                   
                    fibList.Insert(seqNumber, tmp2);
                    seqNumber++;

                    //the new numbers for the equation.
                    startNumber = tmp;
                    startNumber2 = tmp2;                   
                    x = 0;     
                }
            }

            //printing out the list.
            Console.WriteLine("Output:");
            foreach (int num in fibList)
            {
                string tmpNum = Convert.ToString(num);
                Console.Write("{0} ", tmpNum);
            }
            Console.ReadLine();       
        }
    }
}

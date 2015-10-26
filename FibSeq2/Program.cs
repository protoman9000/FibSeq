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
            int tmp2 = 0;
            int seqNumber = 0;
            int startNumber = 0;

            //Number input
            Console.WriteLine("Enter in the desired integer:");
            string insertNumber = Console.ReadLine();
            int DInterger = Convert.ToInt16(insertNumber);

            //Creating a list to store the number sequence
            List<int> fibList = new List<int>();
            fibList[seqNumber] = tmp2;
            seqNumber++;
            int startNumber2 = tmp + 1;

            //The this is set up is by making startNumber as one, if it pass
            //the disired interger, we increase the startNumber. 
            for (int x = 0; x < DInterger; x++)
            {
                int insert = startNumber + startNumber2;
                if (insert <= DInterger)
                {
                    fibList[seqNumber] = insert;
                    seqNumber++;
                }
                else
                {
                    tmp++;
                    x = 0;
                    seqNumber = 1;
                }
            }

            //printing out the list.
            foreach (int num in fibList)
            {
                string tmpNum = Convert.ToString(num);

            }
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
           // StreamReader numFile = File.OpenText("C:\\Moamen\\numbers.txt");
            for (int i = 0; i < 100; i++)
            {
                // numbers[i] = Convert.ToInt32(numFile.ReadLine(), 10);
                numbers[i] = i;
            }
            int searchNumber;
            Console.WriteLine("Enter a Number to Search For :");
            searchNumber = Convert.ToInt32( Console.ReadLine(),10);
            bool found;
            found = SeqSearch(numbers, searchNumber);
            if (found)
            {
                Console.WriteLine(searchNumber + ": is in the array.");
            }
            else
            {
                Console.WriteLine(searchNumber+": is not in the array.");
            }
        }

        private static bool SeqSearch(int[] numbers, int searchNumber)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
               if( numbers[i] == searchNumber)
                {
                    return true;
                }
               

            }
            return false;
        }
    }
}

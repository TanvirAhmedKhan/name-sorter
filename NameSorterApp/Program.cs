using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorterApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string inputFilePath = "../../../unsorted-names-list.txt";
         //   string outputFilePath = "../../../sorted-names-list.txt";
            string outputFilePath = "sorted-names-list.txt";
            ISorter GlobalXNameSorter = new NameSorter(inputFilePath, outputFilePath);
            GlobalXNameSorter.sort();



            Console.WriteLine("Check the Sorted List");
            Console.WriteLine("----------------------------------------");

            // read from output file
            string[] sortedList = System.IO.File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, outputFilePath));
            foreach (string fullName in sortedList)
                Console.WriteLine(fullName);


            Console.ReadKey(true);
        }
    }
}

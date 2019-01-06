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
            string inputFilePath = "unsorted-names-list.txt";
            string outputFilePath = "sorted-names-list.txt";
            if (args.Length == 1)
            {
                ISorter GlobalXNameSorter = new NameSorter(args[0], outputFilePath);
                GlobalXNameSorter.Sort();
                GlobalXNameSorter.PrintOutputList();
            }
            else
            {
                ISorter GlobalXNameSorter = new NameSorter(inputFilePath, outputFilePath);
                GlobalXNameSorter.Sort();
                GlobalXNameSorter.PrintOutputList();
            }
            Console.ReadKey(true);
        }
    }
}

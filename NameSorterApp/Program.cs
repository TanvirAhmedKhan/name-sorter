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
            string outputFilePath = "sorted-names-list.txt";
            ISorter GlobalXNameSorter = new NameSorter(inputFilePath, outputFilePath);
            GlobalXNameSorter.sort();
            GlobalXNameSorter.printOutputList();
            Console.ReadKey(true);
        }
    }
}

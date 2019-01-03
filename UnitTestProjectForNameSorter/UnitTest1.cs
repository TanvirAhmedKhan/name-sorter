using NameSorterApp;
using System;
using Xunit;

namespace UnitTestProjectForNameSorter
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameSorter()
        {
            string input = "../../../unsorted-names-list.txt";
            string output = "Test-ouput.txt";
            ISorter GlobalXNameSorter = new NameSorter(input, output);
            GlobalXNameSorter.sort();
        }

        [Fact]
        public void TestPrintingOutputFile()
        {
            string input = "../../../unsorted-names-list.txt";
            string output = "Test-ouput.txt";
            ISorter GlobalXNameSorter = new NameSorter(input, output);
            GlobalXNameSorter.sort();
            GlobalXNameSorter.printOutputList();
        }
    }
}

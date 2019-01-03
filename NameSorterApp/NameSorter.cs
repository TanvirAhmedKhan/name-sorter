using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorterApp
{
    public class NameSorter : ISorter
    {
        List<Person> list = new List<Person>();
        private string inputFilePath, outputFilePath;

        public NameSorter(string input, string output)
        {
            inputFilePath = Path.Combine(Environment.CurrentDirectory, input);
            outputFilePath = Path.Combine(Environment.CurrentDirectory, output);
        }

        void ISorter.sort()
        {
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("InputFile does not exist.");
            }
            else
            {
                string[] lines = System.IO.File.ReadAllLines(inputFilePath);
                foreach (String each in lines)
                {
                    string[] names = each.Split(' ');
                    string givenName = names.First();
                    if (names.Length > 2)
                    {
                        for (int i = 1; i < names.Length - 1; i++)
                        {
                            givenName += " " + names[i];
                        }
                    }
                    string lastName = names.Last();
                    list.Add(new Person() { GivenName = givenName, LastName = lastName });
                }
                //sorting the list
                list = list.OrderBy(x => x.LastName).ThenBy(x => x.GivenName).ToList();

                using (FileStream fs = File.Create(outputFilePath))
                {
                    byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                    foreach (Person each in list)
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(each.GivenName + " " + each.LastName);
                        fs.Write(info, 0, info.Length);
                        fs.Write(newline, 0, newline.Length);
                    }

                }
            }
        }

        void ISorter.printOutputList()
        {
            Console.WriteLine("----------------------------------------");
            if (File.Exists(outputFilePath))
            {
                string[] sortedList = System.IO.File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, outputFilePath));
                if (sortedList.Length == 0)
                {
                    Console.WriteLine("The file is empty");
                }
                else
                {
                    foreach (string fullName in sortedList)
                        Console.WriteLine(fullName);
                }
            }
            else
            {
                Console.WriteLine("The ouput file does not exist.");
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}

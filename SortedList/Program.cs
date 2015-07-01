using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new List<string> { "One", "Two", "Three", "Yellow", "Green", "Tom", "Road" };
            var finalList = Sort(theList, 'T');
            finalList.Sort();

            foreach (string word in finalList)
            {
                Console.WriteLine(word);
            }
        }

        static List<string> Sort(List<string> theList, char theChar)
        {
            var listWithChar = new List<string>();

            foreach (string word in theList)
            {
                if (word.StartsWith(theChar.ToString()))
                {
                    listWithChar.Add(word);
                }
            }
            return listWithChar;

        }

    }
}

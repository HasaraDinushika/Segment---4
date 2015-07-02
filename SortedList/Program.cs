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
            // save the list of strings and call the Sort method with the character
            // this outputs all the strings that starts with the input character
            var theList = new List<string> { "One", "Two", "Three", "Yellow", "Green", "Tom", "Road" };
            var finalList = Sort(theList, 'T');
            finalList.Sort();

            // display the final list
            foreach (string word in finalList)
            {
                Console.WriteLine(word);
            }
        }

        static List<string> Sort(List<string> theList, char theChar)
        {
            var listWithChar = new List<string>();

            // check whether the word starts with the given character
            // if the word starts with given character add this word to the separate list
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

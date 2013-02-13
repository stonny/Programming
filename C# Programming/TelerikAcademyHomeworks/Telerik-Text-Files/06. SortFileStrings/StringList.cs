/* Write a program that reads a text file containing a list of strings,
 * sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria	->		Maria
	George			Peter
*/
namespace _06.SortFileStrings
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;

    class StringList
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("../../output.txt"))
            {
                using (StreamReader sr = new StreamReader("../../input.txt"))
                {
                    List<string> myList = new List<string>();
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != string.Empty)
                        {
                            myList.Add(line);
                        }
                        line = sr.ReadLine();
                    }
                    myList.Sort();
                    for (int k = 0; k < myList.Count; k++)
                    {
                        sw.WriteLine(myList[k]);
                    }
                }
            }
        }
    }
}

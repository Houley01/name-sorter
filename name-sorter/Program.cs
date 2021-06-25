using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = args[0];
            /* Create a list and read the document*/
            List<string> listOfNamesFromDocument = ReadandWriteFile.ReadFile(fileLocation);
            /* Run the Bubble sorting algroithm */
            List<string> sortedList = SortAlgorithm.SortList(listOfNamesFromDocument);
         
            /*Console.WriteLine("Sorted List:");*/
            WriteToConsole.PrintList(sortedList);
            ReadandWriteFile.WriteFile(sortedList, ".\\stored-names-list.txt");
            Console.ReadKey();
        }

        
    }
}

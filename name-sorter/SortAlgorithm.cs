using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    class SortAlgorithm
    {
        private static string temp;
        
       public static List<string> SortList(List<string> listOfNames)
       {
            /* 
             * Bubble Sort Algorithm 
             * 
             * Loops through list of names comparing 2 names together. 
             * int masterLoop is equal the the list size minus 2. masterLoop runs through the all the names 
             * int index is reset every loop of masterLoop, index job is to change the possiton in the list.
             */

            for (int masterLoop = 0; masterLoop <= listOfNames.Count - 2; masterLoop++) 
            { 
                for (int index = 0; index <= listOfNames.Count - 2; index++)
                {
                    if (CompareNames(listOfNames[index], listOfNames[index+1]) == 1)
                    {
                        temp = listOfNames[index + 1];
                        listOfNames[index + 1] = listOfNames[index];
                        listOfNames[index] = temp;
                    }
                }
            }
            return listOfNames;
       }

        private static int CompareNames(string name1, string name2) {
            // Split the full name up before compairing the last name
            String[] splitName1 = name1.Split(' '); 
            String[] splitName2 = name2.Split(' ');
            // Find the sizeOf the array, minus 1 to the get the last name
            return String.Compare(splitName1[splitName1.Length-1], splitName2[splitName2.Length-1]);
        }
    }
}

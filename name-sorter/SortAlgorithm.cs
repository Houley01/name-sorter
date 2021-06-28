using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class SortAlgorithm
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

         public static int CompareNames(string name1, string name2) {
            // Split the full name up before compairing the last name
            string[] splitName1 = name1.Split(' '); 
            string[] splitName2 = name2.Split(' ');
            // Find the sizeOf the array, minus 1 to the get the last name
            int compareValue =  string.Compare(splitName1[splitName1.Length - 1].ToLower(), splitName2[splitName2.Length - 1].ToLower());
            
            // if compareValue is equal to 0 than compare any given name
            if (compareValue == 0) {
                // Remove the last name from the array
                splitName1[splitName1.Length - 1] = null;
                splitName2[splitName2.Length - 1] = null;
                // Join all the given names together and make them lowercase
                name1 = string.Concat(splitName1).ToLower(); 
                name2 = string.Concat(splitName2).ToLower();
                // Compare the given name string
                compareValue = string.Compare(name1, name2);
            }
            return compareValue;
        }
    }
}

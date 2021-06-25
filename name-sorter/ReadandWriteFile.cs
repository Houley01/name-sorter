using System;
using System.IO;
using System.Collections.Generic;

namespace name_sorter
{
    public static class ReadandWriteFile
    {
        static String line;

        public static List<string> ReadFile(string fileName)
        {
            List<string> listOfNames = new List<string>();
            try
            {
                // Pass the file name to Stream Reader
                StreamReader inputFile = new StreamReader(fileName);
                // Read the first line of file
                line = inputFile.ReadLine();

                // Loop until a NULL is returned
                while (line != null)
                {
                    // Add Person name to Class person Name
                    listOfNames.Add(line);
                    // Read the next line in the document
                    line = inputFile.ReadLine();
                }

                // Close the SteamReader file 
                inputFile.Close();
                return listOfNames;
            }
            catch (Exception exceptionError)
            {
                Console.WriteLine("An Exception has occured: " + exceptionError.Message);
            }
            return null;
        }

        /*
         * WriteFile(List<string> names)
         * Argument names is a list of strings that are to be written out to file
         * Argument fileName is where the file will be stored in relation to where the project is running
         */
        public static void WriteFile(List<string> names, string fileName)
        {
            try
            {
                // Setup StreamWriter
                StreamWriter outputFile = new StreamWriter(fileName);

                // Write to the file each item in the list 
                foreach(string name in names)
                {
                    outputFile.WriteLine(name);
                }

                outputFile.Close();
            }
            catch (Exception exceptionError)
            {
                Console.WriteLine("An Exception has occured: " + exceptionError.Message);
            }
        }
    }
}

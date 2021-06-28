using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    class VerifyUserInput
    {
        public static bool CheckNumberOfNames(string nameToCheck) {
            string[] splitName = nameToCheck.Split(' '); 

                // If array size is bigger than 1 and equal or less than 4
            if (splitName.Length > 1 && splitName.Length <= 4)
            {
                return true;
            } else {
                Console.WriteLine("ERROR: Name '" + nameToCheck + "' in file does not meet the following rules");
                Console.WriteLine("This name needs at least 1 Given Name and MAX of 3 Given Names");
                Console.WriteLine("This name can have 4 names in total");
                Console.WriteLine("");
                return false;
            }
            
        } 

        public static void CheckArgs(string[] args)
        {
            // More than 1
            if (args.Length > 1)
            {
                Console.WriteLine("Too many Commands have been given");
                Console.WriteLine("The Program only takes 2 command to run;");
                Console.WriteLine("e.g. ./Program_Name ./unsorted-names-list.txt");
                Console.WriteLine("Press ENTER to end program");

                Console.ReadLine();
                Environment.Exit(1);
            }
            // Less than 1 
            else if (args.Length < 1)
            {
                Console.WriteLine("Not enough Command have been given");
                Console.WriteLine("The Program only takes 2 command to run;");
                Console.WriteLine("e.g. ./Program_Name ./unsorted-names-list.txt");
                Console.WriteLine("Press ENTER to end program");
                Console.ReadLine();
                Environment.Exit(1);
            }
        }

    }
}

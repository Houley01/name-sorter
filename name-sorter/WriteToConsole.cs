using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class WriteToConsole
    {
        public static void PrintList(List<string> listToPrint)
        {
            foreach (string listItem in listToPrint)
            {
                Console.WriteLine(listItem);
            }
            Console.WriteLine("\n");
        }
    }
}

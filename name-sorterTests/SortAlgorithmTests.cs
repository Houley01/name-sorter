using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Tests
{
    [TestClass()]
    public class SortAlgorithmTests
    {
        [TestMethod()]
        // Test 2 different last names
        public void CompareNamesTest1()
        {
            string name1 = "John Alpha";
            string name2 = "John Beta";
            int expectedResult = -1; // Name 1 before name 2
            int testResult = SortAlgorithm.CompareNames(name1, name2);
            Assert.AreEqual(expectedResult, testResult);
        }
        [TestMethod()]
        // Test 2 different last names
        public void CompareNamesTest2()
        {
            string name1 = "John Beta";
            string name2 = "John Alpha";
            int expectedResult = 1; // Name 1 AFTER name 2
            int testResult = SortAlgorithm.CompareNames(name1, name2);
            Assert.AreEqual(expectedResult, testResult);
        }
        [TestMethod()]
        // Test same name for both last name and given names
        public void CompareNamesTest3()
        {
            string name1 = "John Alpha";
            string name2 = "John Alpha";
            int expectedResult = 0; // Same Name
            int testResult = SortAlgorithm.CompareNames(name1, name2);
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod()]
        // Test for both Same last name but different number of given names
        public void CompareNamesTest4()
        {
            string name1 = "John Bravo Charlie Alpha";
            string name2 = "John Alpha";
            int expectedResult = 1; // Name 1 after name 2
            int testResult = SortAlgorithm.CompareNames(name1, name2);
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod()]
        // Test for both Same last name but different given names
        public void CompareNamesTest5()
        {
            string name1 = "Bravo Alpha";
            string name2 = "John Alpha";
            int expectedResult = -1; // Name 1 before name 2
            int testResult = SortAlgorithm.CompareNames(name1, name2);
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod()]
        public void SortListTest()
        {
            List<string> expectedResults = new List<string>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };

            // List to be sorted
            List<string> unsortedNames = new List<string>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter"

            };
            // Create a new list and run the sortList Function
            List<string> actualResults = SortAlgorithm.SortList(unsortedNames);

            // Compare list expected List to actual results from running program
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }
    }
}
/// Week 12	Lab  2
/// File Name: Program.cs
/// @author: Antonio Monteiro

using System;
using System.Collections.Generic;
using System.IO;

namespace Lecture_12_Labs {
    class Program {
        static void Main(string[] args) {

            //create boynames and girlnames dictionary
            Dictionary<string, int> boyNames = new Dictionary<string, int>();
            Dictionary<string, int> girlNames = new Dictionary<string, int>();

            //using space as delimiter character
            char[] delimiterChars = { ' ' };

            //create the boyNames dictionary based on text file
            using (StreamReader reader = new StreamReader("boynames-1.txt")) {
                string line = null;
                while ((line = reader.ReadLine()) != null) {
                    string[] lineData = line.Split(delimiterChars);
                    boyNames.Add(lineData[0], Int32.Parse(lineData[1]));
                }
            }

            //create the girlNames dictionary based on textFile
            using (StreamReader reader = new StreamReader("girlnames-1.txt")) {
                string line = null;
                while ((line = reader.ReadLine()) != null) {
                    string[] lineData = line.Split(delimiterChars);
                    girlNames.Add(lineData[0], Int32.Parse(lineData[1]));
                }
            }

            //get name user wants and set to lowercase
            Console.WriteLine("Please input a name to search for.");
            string name = Console.ReadLine();
            name = name.ToLower();

            //variables for search
            int rankBoys = 1;
            int rankGirls = 1;
            bool nameFoundBoys = false;
            bool nameFoundGirls = false;

            foreach (KeyValuePair<string, int> val in boyNames) {
                if (val.Key.ToLower() == name) {
                    Console.WriteLine("{0} is ranked {1} in popularity among boys with {2} namings", val.Key, rankBoys, val.Value);
                    nameFoundBoys = true;
                    break;
                }
                else {
                    rankBoys++;
                }
            }

            foreach (KeyValuePair<string, int> val in girlNames) {
                if (val.Key.ToLower() == name) {
                    Console.WriteLine("{0} is ranked {1} in popularity among girls with {2} namings", val.Key, rankGirls, val.Value);
                    nameFoundGirls = true;
                    break;
                }
                else {
                    rankGirls++;
                }
            }

            if (!nameFoundBoys) {
                Console.WriteLine("{0} is not ranked among the top 1000 boy names", name);
            }

            if (!nameFoundGirls) {
                Console.WriteLine("{0} is not ranked among the top 1000 girl names", name);
            }

        }
    }
}
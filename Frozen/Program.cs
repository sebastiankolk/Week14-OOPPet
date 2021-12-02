using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string item;
            string number;
            public Frozen(string _name, string _item, string _number)
            {
                name = _name;
                item = _item;
                number = _number;
            }
            public string Name
            {
                get { return name; }
            }
            public string Item
            {
                get { return item; }
            }
            public string Number
            {
                get { return number; }
            }
        }
        static void Main(string[] args)
        {
            List<string> frozenListFromFile = getFrozenFromFile().ToList();
            List<Frozen> listOfFrozen = new List<Frozen>();

            foreach (string frozenThing in frozenListFromFile)
            {
                string[] tempArray = frozenThing.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1], tempArray[2]);

                listOfFrozen.Add(newFrozen);
            }
            foreach (Frozen frozen in listOfFrozen)
            {
                Console.WriteLine($"{frozen.Name} wants {frozen.Item} for Christmas");
            }
        }
        public static string[] getFrozenFromFile()
        {
            string fullfilePath = @"C:\Users\opilane\samples\frozen.txt";

            string[] dataFromFile = File.ReadAllLines(fullfilePath);
            return dataFromFile;
        }
        public static void ShowDataFromArray(string[] somearray)
        {
            foreach (string line in somearray)
            {
                Console.WriteLine(line);
            }
        }
    }
}
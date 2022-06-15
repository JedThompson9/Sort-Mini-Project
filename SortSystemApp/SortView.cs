using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSystemApp
{
    public class SortView
    {
        public void PrintMenu()
        {
            Console.WriteLine("Welcome to the Sorting Algorithm Program");
            Console.WriteLine("Choose from one of the following options below");
            Console.WriteLine("[S]ort a randomly generated array");
            Console.WriteLine("E[x]it the program");
            Console.Write("Please choose an option: ");
        }

        public void PrintSortSelectionMethod()
        {
            Console.WriteLine("Please select a sorting algorithm below");
            Console.WriteLine("    [B]ubble, [M]erge or [D]ot[n]et");
            Console.WriteLine("");
            Console.Write("Please provide your selection: ");
        }

        public void PrintSizeSelection()
        {
            Console.Write("Please enter size of array to generate: ");
        }

        public void PrintUnsortedArray(string message)
        {
            Console.WriteLine(message);
        }
          
        public void PrintAlgorithmSelectionAndOutput(string message) 
        {
            Console.WriteLine(message);
        }

        public void PrintSortAlgorithmChosen(string message)
        {
            Console.WriteLine("Sorted Algorithm chosen: " + message);
        }

        public void PrintSortedArray()
        {
            Console.WriteLine("Sorted array: ");
        }

        public void PrintTimeTaken(string message)
        {
            Console.WriteLine("Execution time in seconds: " + message);
        }
    }
}

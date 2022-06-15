using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSystemApp
{
    public enum Algorithm
    {
        Bubble,
        Merge,
        dotNet
    }

    public enum Step
    {
        Menu,
        SortSelection,
        SizeSelection,
        Output
    }

    public class SortController
    {
        private SortView _view;
        public Algorithm SelectedAlgorithm;
        public Step CurrentStep = Step.Menu;
        Stopwatch stopwatch = new Stopwatch();

        string _output;
        string _unsortedOutput;

        public SortController(SortView view)
        {
            _view = view;
        }

        public void UpdateView()
        {
            CurrentStep++;
            
            switch (CurrentStep)
            {
                case Step.Menu:
                    _view.PrintMenu();
                    break;
                case Step.SortSelection:
                    _view.PrintSortSelectionMethod();
                    break;
                case Step.SizeSelection:
                    _view.PrintSizeSelection();
                    break;
                case Step.Output:
                    Console.WriteLine("-------------------------------------------------------------");
                    _view.PrintSortAlgorithmChosen(SelectedAlgorithm.ToString());
                    Console.WriteLine(" ");
                    _view.PrintUnsortedArray(_unsortedOutput);
                    Console.WriteLine(" ");
                    _view.PrintAlgorithmSelectionAndOutput(_output);
                    Console.WriteLine(" ");
                    _view.PrintTimeTaken(stopwatch.Elapsed.TotalSeconds.ToString());
                    break;
            }
            

        }

        public bool SetSelectedAlgorithm(char c)
        {
            c = char.ToLower(c);
            switch (c)
            {
                case 'b':
                    SelectedAlgorithm = Algorithm.Bubble;
                    return true;
                case 'm':
                    SelectedAlgorithm = Algorithm.Merge;
                    return true;
                case 'd':
                case 'n':
                    SelectedAlgorithm = Algorithm.dotNet;
                    return true;
                default:
                    return false;
            }
        }   
        
        public void ParseInputSize(string input, out int arraySize)
        {
            bool isNumber = int.TryParse(input, out arraySize);

            if (!isNumber)
            {
                Console.WriteLine("Error! That's not a number!");
                throw new AggregateException();
            }
        }

        public int[] GenerateArray(int size)
        {
            if (size <= 0 || size > 255)
            {
                throw new ArgumentOutOfRangeException("Number provided is too large/small");
            }

            int[] GeneratedArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < GeneratedArray.Length; i++)
            {
                GeneratedArray[i] = GenerateRandomInt(rnd);
            }

            return GeneratedArray;
        }
        static int GenerateRandomInt(Random rnd)
        {
            return rnd.Next(1, 255);
        }
        public string ExecuteSort(int[] arrayToSort)
        {
            switch (SelectedAlgorithm)
            {
                case Algorithm.Merge:
                    MergeSort merger = new MergeSort();
                    return ArrayToString(merger.Sort(arrayToSort), "Sorted Array: ");
                case Algorithm.Bubble:
                    BubbleSort Bubbler = new BubbleSort();
                    var result = Bubbler.Sort(arrayToSort);
                    return ArrayToString(result, "Sorted Array: ");
                case Algorithm.dotNet:
                    DotNetSort dotNetSort = new DotNetSort();
                    return ArrayToString(dotNetSort.Sort(arrayToSort), "Sorted Array: ");
                default:
                    return string.Empty;
            }
        }

        public string ArrayToString(int[] arrayToString, string initialMessage)
        {
            string output = "";
            foreach (int i in arrayToString)
            {
                output += i + ", ";
            }
            return initialMessage + output.Remove(output.Length - 2);    
            
        }
    
        public void GenerateAndSort(int size) 
        {
            var array = GenerateArray(size);
            _unsortedOutput = ArrayToString(array, "Unsorted Array: ");
            StartTimer(true);
            _output = ExecuteSort(array);
            StartTimer(false);
        }

        public void StartTimer(bool start = true)
        {                   
            if (start)
            {
                stopwatch.Start();
            }
            else
            {
                stopwatch.Stop();
            }      
        }
    }
}

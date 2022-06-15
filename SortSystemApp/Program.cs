using System;
namespace SortSystemApp
{
    public class Program
    {
        public static void Main() 
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
         
            SortView sortView = new SortView();

            SortController sortController = new SortController(sortView);

            string input;

            sortController.UpdateView();
            
            input = Console.ReadLine();
            sortController.SetSelectedAlgorithm(input.ToCharArray().First());
            sortController.UpdateView();
            
            input = Console.ReadLine();
            sortController.ParseInputSize(input, out int arrayToGenerateSize);
            sortController.GenerateAndSort(arrayToGenerateSize);
            sortController.UpdateView();
            Console.Read();
        }

    }
}

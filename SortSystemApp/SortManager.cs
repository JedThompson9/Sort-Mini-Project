using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortSystemApp
{
    public class SortManager
    {
        public static SortAlgorithm GetAlgorithm(Algorithm Algorithm) 
        {
            SortAlgorithm sortAlgorithm = null;
            switch (Algorithm)
            {
                case Algorithm.Merge:
                    sortAlgorithm = new MergeSort();
                    break;
                case Algorithm.Bubble:
                    sortAlgorithm = new BubbleSort();
                    break;
                case Algorithm.dotNet:
                    sortAlgorithm = new DotNetSort();
                    break;
            }
            return sortAlgorithm;
        }
    }
}
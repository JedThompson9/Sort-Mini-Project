using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSystemApp
{
    public class BubbleSort : SortAlgorithm
    {
        public override int[] Sort(int[] array)
        {
            if (array == null) throw new ArgumentNullException();
            if (array.Length == 0) return Array.Empty<int>();

            bool done = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                        done = false;
                    }
                    if (done)
                    {
                        break;
                    }
                }
            }
            return array;
        }
    }
}

  


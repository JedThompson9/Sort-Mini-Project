using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSystemApp
{
    public class DotNetSort : SortAlgorithm
    {
        public override int[] Sort(int[] array)
        {
            if (array == null) throw new ArgumentNullException();
            if (array.Length == 0) return Array.Empty<int>();
            Array.Sort(array);
            return array;
        }
    }
}

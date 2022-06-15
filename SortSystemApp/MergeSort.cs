namespace SortSystemApp
{
    public class MergeSort : SortAlgorithm
    {
        public override int[] Sort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            // Base case
            if (array.Length <= 1)
                return array;

            int mid = array.Length / 2;

            left = new int[mid];

            // If array has even number of elements, left and right arrays will have same number of elements
            if (array.Length % 2 == 0)
                right = new int[mid];
            // if array has odd number of elements, right array will have one more element than left array
            else
                right = new int[mid + 1];

            // Populate left array
            for (int i = 0; i < mid; i++)
                left[i] = array[i];

            // Populate right array
            // Start index from midpoint, as left array already populated
            int x = 0;
            for (int i = mid; i< array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            // Recursively sort left array
            left = Sort(left);
            // Recursively sort right array
            right = Sort(right);
            // Merge sorted arrays
            result = Merge(left, right);

            return result;
        }

        // Combines the two sorted arrays into one
        public int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[right.Length + left.Length];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            // While
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}

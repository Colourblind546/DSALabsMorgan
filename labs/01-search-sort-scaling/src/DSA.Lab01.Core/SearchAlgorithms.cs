using System;

namespace DSA.Lab01
{
    public static class SearchAlgorithms
    {
        public static int LinearSearch(int[] values, int target)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            for (int i = 0; i < values.Length; ++i)
            {
                if (values[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] sortedValues, int target)
        {
            if (sortedValues == null)
            {
                throw new ArgumentNullException(nameof(sortedValues));
            }

            int low = 0;
            int high = sortedValues.Length - 1;
            int middle = (high - low) / 2 + low;

            while(true)
            {
                if (target == sortedValues[middle])
                {
                    return middle;
                }

                if (high == low)
                {
                    break;
                }

                if (target > sortedValues[middle])
                {
                    low = middle + 1;
                }
                else if (target < sortedValues[middle])
                {
                    high = middle - 1;
                }

                middle = (high - low) / 2 + low;

            }

            // TODO: Implement binary search.
            // The input to this method is guaranteed to be sorted in ascending order.
            //
            // Suggested plan:
            // 1. Keep track of a low and high index.
            // 2. Inspect the middle value.
            // 3. Return the index if it matches.
            // 4. Otherwise discard either the lower or upper half.
            // 5. Repeat while there is still a valid search range.
            return -1;
        }
    }
}

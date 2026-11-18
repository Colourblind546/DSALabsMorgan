using System;

namespace DSA.Lab01
{
    public static class SortAlgorithms
    {
        public static void InsertionSort(int[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            int currentSortValue;
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    currentSortValue = values[i];
                    int moveIndex = i;

                    while (true)
                    {
                        if (moveIndex == 0)
                        {
                            break;
                        }
                        if (values[moveIndex - 1] <= currentSortValue)
                        {
                            break;
                        }
                        else if (values[moveIndex - 1] > currentSortValue)
                        {
                            values[moveIndex] = values[moveIndex - 1];
                            moveIndex--;
                        }
                    }

                    values[moveIndex] = currentSortValue;

                    Console.WriteLine(string.Join(", ", values));
                }
            }
            

            // TODO: Sort the array in ascending order using insertion sort.
            //
            // Think of values[0..i-1] as the already-sorted part.
            // For each next value:
            // 1. Store the value you want to insert.
            // 2. Shift larger values one position to the right.
            // 3. Put the stored value into the gap.
        }
    }
}

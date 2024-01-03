using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsC_
{
    public class BinarySearch
    {

        public BinarySearch() {
            int[] arr = new int[1000000];
            int arraySize = arr.Length;
            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = i + 1;
            }
            var watch = Stopwatch.StartNew();
            int target = 45670, targetIndex = -1, currentSize = arraySize;
            int result = BinarySearchMethod(0, currentSize, target, arr);
            Console.WriteLine(result);

            watch.Stop();
            Console.WriteLine(
                $"The Execution time of the program is {watch.ElapsedMilliseconds}ms");
        }

        public int BinarySearchMethod(int minSize, int maxSize, int targetValue, int[] array)
        {
            decimal indexToCompare = -1;

            decimal middleValue = (minSize + maxSize) / 2;

            if (middleValue % 1 == 0)
            {
                if (array[(int)middleValue - 1] == targetValue)
                {
                    return (int)middleValue - 1;
                }
                else if (array[(int)middleValue - 1] > targetValue)
                {
                    return BinarySearchMethod(minSize, (int)middleValue, targetValue, array);
                }
                return BinarySearchMethod((int)middleValue, maxSize, targetValue, array);
            }
            decimal leftValue = middleValue - 0.5m;
            decimal rightValue = middleValue + 0.5m;
            if (array[(int)leftValue] == targetValue)
            {
                return (int)leftValue;
            }
            if (array[(int)rightValue] == targetValue)
            {
                return (int)rightValue;
            }
            else if (array[(int)leftValue - 1] > targetValue)
            {
                return BinarySearchMethod(minSize, (int)rightValue, targetValue, array);
            }
            return BinarySearchMethod((int)rightValue, maxSize, targetValue, array);
        }

    }

}

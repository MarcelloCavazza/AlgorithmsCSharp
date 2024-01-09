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
            Console.WriteLine("Say a target");
            int target = int.Parse(Console.ReadLine());

            var watch = Stopwatch.StartNew();
            int currentSize = arraySize;
            int result = BinarySearchMethod(0, currentSize, target, arr);
            Console.WriteLine(result);

            watch.Stop();
            Console.WriteLine(
                $"The Execution time of the program is {watch.ElapsedMilliseconds}ms");
        }

        public int BinarySearchMethod(int minSize, int maxSize, int targetValue, int[] array)
        {
            if (targetValue == maxSize) return maxSize - 1;
            if (targetValue == minSize) return minSize - 1;
            if (minSize >= maxSize) return -1;

            int middleValue = (minSize + maxSize) / 2;
            if (array[middleValue - 1] == targetValue)
            {
                return middleValue - 1;
            }
            else if (array[middleValue - 1] > targetValue)
            {
                return BinarySearchMethod(minSize, middleValue, targetValue, array);
            }
            return BinarySearchMethod(middleValue, maxSize, targetValue, array);
        }

    }

}

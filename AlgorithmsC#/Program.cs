using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

int[] arr = new int[1000000];
int arraySize = arr.Length;
for (int i = 0; i < arraySize; i++)
{
    arr[i] = i + 1;
}
var watch = Stopwatch.StartNew();
int target = 45670, targetIndex = -1, currentSize = arraySize;
int result = BinarySearch(0, currentSize, target, arr);
Console.WriteLine(result);
static int BinarySearch(int minSize, int maxSize, int targetValue, int[] array)
{
    decimal indexToCompare = -1;

    decimal middleValue = (minSize+maxSize)/2;

    if (middleValue % 1 == 0)
    {
        if(array[(int)middleValue-1] == targetValue) 
        {
            return (int)middleValue - 1;
        }
        else if(array[(int)middleValue - 1] > targetValue)
        {
            return BinarySearch(minSize, (int)middleValue, targetValue, array);
        }
        return BinarySearch((int)middleValue, maxSize, targetValue, array);
    }
    else
    {
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
            return BinarySearch(minSize, (int)rightValue, targetValue, array);
        }
        return BinarySearch((int)rightValue, maxSize, targetValue, array);
    }
}

watch.Stop();
Console.WriteLine(
    $"The Execution time of the program is {watch.ElapsedMilliseconds}ms");
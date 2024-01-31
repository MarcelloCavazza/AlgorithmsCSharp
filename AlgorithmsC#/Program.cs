using AlgorithmsC_;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

int value = 0;

while (value == 0)
{
    Console.WriteLine("Select an option:\n" +
    "1- Exit\n" +
    "2- Binary Search\n");
    string answer = Console.ReadLine();

    Int32.TryParse(answer, out value);
    switch (value)
    {
        case 1:
            Console.Clear();
            break;
        case 2:
            Console.Clear();
            Bs.BinarySearch();
            Reset.ResetAfterExecution(ref value);
            break;
        case 3:
            Console.Clear();

            Reset.ResetAfterExecution(ref value);
            break;
        default:
            Reset.ResetAfterExecution(ref value);
            break;
    }
}
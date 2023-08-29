using System;

class Program
{
    static void Main()
    {
        int[] array = { 7, 3, 9, 2, 5 };
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int num in array)
        {
            if (num < smallest)
            {
                secondSmallest = smallest;
                smallest = num;
            }
            else if (num < secondSmallest && num != smallest)
            {
                secondSmallest = num;
            }
        }

        Console.WriteLine("Second smallest element: " + secondSmallest);
    }
}

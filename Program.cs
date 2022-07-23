namespace AlgorithmsLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = { 5, 2, 7, 6, 1, 3, 4 };
            someArray = QuickSorting(someArray, 0, someArray.Length - 1);
            foreach (int i in someArray)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        static int[] QuickSorting(int[] arr, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return arr;
            int pivotIndex = minIndex;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (arr[i] < arr[maxIndex])
                {
                    (arr[i], arr[pivotIndex]) = (arr[pivotIndex], arr[i]);
                    pivotIndex++;
                }
            }
            (arr[pivotIndex], arr[maxIndex]) = (arr[maxIndex], arr[pivotIndex]);
            QuickSorting(arr, minIndex, pivotIndex - 1);
            QuickSorting(arr, pivotIndex + 1, maxIndex);
            return arr;
        }
    }
}   
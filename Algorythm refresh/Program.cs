class Program 

{
static void Main()
    {
        int[] array = { 3, 5, 2, 1, 5, 6, 7, 2, 3, 4, 5 };
        PrintArray(array);
        QuickSort(array);
        PrintArray(array);
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
    
    static void swap(ref int x,ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static int[] QuickSort(int[] array)
    {
        return QuickSort(array, 0, array.Length - 1);
    }
    static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex);
        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    static int Partition(int[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }
}
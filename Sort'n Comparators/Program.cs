class Program
{

    static void sort(int[] array, int size)
    {
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < size - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    swap(array, i);
                    swapped = true;
                }

            }
        } while (swapped);

    }
    static void swap(int[] array, int i)
    {
        int temp = array[i];
        array[i] = array[i + 1];
        array[i + 1] = temp;
    }
    static void printArray(int[] array, int size)
    {
        for(int i = 0;i < size;i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] array = { 1, 5, 6, 5, 4,3, 4, 7, 8 };
        int size = array.Length;

        printArray(array, array.Length);
        
        sort(array, size);
        printArray(array, array.Length);

    }
}
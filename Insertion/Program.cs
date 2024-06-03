class Program
{
    static void Main()
    {
        int[] array = { 3, 5, 2, 1, 5, 6, 7, 2, 3, 4, 5 };
        PrintArray(array);
        PrintArray(array);
    }

    static void swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}
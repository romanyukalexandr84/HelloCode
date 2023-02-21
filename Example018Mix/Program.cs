int[] arr = {1, 8, 9, 5 ,2, 6, 4, 1, 15};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine ();
}

void MixArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next (0, array.Length);
        Console.Write($"{array[j]} ");
    }
}

PrintArray (arr);
MixArray (arr);
Console.WriteLine ();
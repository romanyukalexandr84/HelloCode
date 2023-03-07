void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
 
int count = 0;
int index1 = 0;
while (count < 10)
{
    index1 = new Random().Next(0,10);
    Console.WriteLine(array[index1]);
    count++;
}


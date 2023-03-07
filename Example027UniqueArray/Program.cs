/*void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int temp = new Random().Next(10,100);
        while (arr.Contains(temp))
        {
            temp = new Random().Next(10,100);
        }
        arr [i] = temp;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
}


int[] array = new int[15];
FillArray(array);
PrintArray(array);
Console.WriteLine();
 */


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write("0" + matr[i, j] + " ");
            }
            else
            {
                Console.Write(matr[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    int i = 0;
    int j = 0;
    int count = 1;

    while (count <= Math.Pow (matr.GetLength(0), 2))
    {
        matr[i, j] = count;
        if (i <= j + 1 && i + j < matr.GetLength(0) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= matr.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > matr.GetLength(0) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
        count++;
    }
}

Console.WriteLine("Введите количество строк и столбцов матрицы");
int quantity = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[quantity, quantity];
FillArray(matrix);

PrintArray(matrix);
Console.WriteLine();

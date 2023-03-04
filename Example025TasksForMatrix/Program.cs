/*
Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] NewArray(int[,] matr1)
{
    int[,] matr = new int[matr1.GetLength(1), matr1.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matr1[j, i];
        }
    }
    return matr;
}

Console.WriteLine("Введите количество строк и столбцов матрицы");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if ((a <= 0) || (b <= 0))
{
    Console.WriteLine("Введите числа больше нуля");
}
else
{
    int[,] matrix = new int[a, b];
    FillArray(matrix);

    PrintArray(matrix);
    Console.WriteLine();

    PrintArray(NewArray(matrix));
    Console.WriteLine();
}


Задача1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] NewArray(int[,] matr1)
{
    int[] arr = new int[matr1.GetLength(1)];
    for (int j = 0; j < matr1.GetLength(1); j++)
    {
        arr[j] = matr1[0, j];
        matr1[0, j] = matr1[matr1.GetLength(0) - 1, j];
        matr1[matr1.GetLength(0) - 1, j] = arr[j];
    }
    return matr1;
}

Console.WriteLine("Введите количество строк и столбцов матрицы");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

while ((a <= 0) || (b <= 0))
{
    Console.WriteLine("Введите числа больше нуля");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = new int[a, b];
FillArray(matrix);

PrintArray(matrix);
Console.WriteLine();

PrintArray(NewArray(matrix));
Console.WriteLine();

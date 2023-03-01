/*Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void FillPrintArray(int[] mas)
{
    for (int i = 0; i < 12; i++)
    {
        mas[i] = new Random().Next(-9, 10);
        Console.Write(mas[i] + " ");
    }
}

int Summin(int[] massiv)
{
    int summinus = 0;
    for (int j = 0; j < 12; j++)
    {
        if (massiv[j] <= 0)
        {
            summinus = summinus + massiv[j];
        }
    }
    return summinus;
}

int Sumpl(int[] arr)
{
    int sumplus = 0;
    for (int k = 0; k < 12; k++)
    {
        if (arr[k] >= 0)
        {
            sumplus = sumplus + arr[k];
        }
    }
    return sumplus;
}

int[] array = new int[12];
FillPrintArray(array);
Console.WriteLine();

Console.WriteLine("Сумма положительных элементов массива = " + Sumpl(array));
Console.WriteLine("Сумма отрицательных элементов массива = " + Summin(array));


Задача 2: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 


void FillArray (int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-99, 100);
    }
}
 
 void PrintArray (int[] arr)
{
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write(arr[k] + " ");
    }
}

 int[] Substitution (int[] massiv)
{
    for (int j = 0; j < massiv.Length; j++)
    {
        massiv[j] = -massiv[j];
    }
    return massiv;
}

Console.WriteLine ("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int[n];

FillArray (array);
PrintArray (array);
Console.WriteLine ();
PrintArray (Substitution (array));
Console.WriteLine ();


Задача 3: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да


void FillArray (int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-9, 10);
    }
}
 
 void PrintArray (int[] arr)
{
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write(arr[k] + " ");
    }
}

bool Check (int[] massiv, int count)
{
    int s = Array.IndexOf (massiv, count);
    if (s == -1) return false;
    else return true;
}

Console.WriteLine ("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

int [] array = new int[n];

FillArray (array);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine (Check(array, number));


Задача 4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

void FillPrintArray(int[] mas)
{
    for (int i = 0; i < 15; i++)
    {
        mas[i] = new Random().Next(-100, 200);
        Console.Write(mas[i] + " ");
    }
}

int CheckArray (int[] arr)
{
    int count = 0;
    for (int j = 0; j < 15; j++)
    {
        if (arr[j] >=10 && arr[j] <=99)
        {
            count++;
        }
    }
    return count;
}

int [] array = new int[15];
FillPrintArray(array);
Console.WriteLine();

Console.WriteLine ("Количество элементов массива, значения которых лежат в отрезке [10,99] = "+CheckArray(array));
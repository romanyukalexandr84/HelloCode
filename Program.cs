// Задача 1
// Реализовать перемешивание массива

// 1. Создание массива
int[] CreateArray(int size)
{
  return new int[size];
}
// 2. ввод числа
int GetNumber(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 3. Печать массива
string Print(int[] array)
{
  string result = String.Empty;
  int len = array.Length;
  int index = 0;
  while (index < len)
  {
    result = result + " " + array[index];
    index++;
  }
  return result;
}


// 4. Заполнение массива
// 4.1 руками

void FillByUser(int[] array)
{
  int size = array.Length;

  int index = 0;

  while (index < size)
  {
    array[index] = GetNumber("Введите " + index + " элемент: ");
    index++;
  }
}

int size = GetNumber("Введите размер массива ");
int[] numbers = CreateArray(size);
System.Console.WriteLine(Print(numbers));

FillByUser(numbers);
System.Console.WriteLine(Print(numbers));

// int[] mas = GetMix(numbers);
// System.Console.WriteLine(Print(numbers));

// 4.2 случайно
// 5. перемешивание массива

// Маша - РЕПО
// Ира
// Ваня
// Коля
//\
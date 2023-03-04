int factorial(int n)
{
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }
    return fact;
}

Console.WriteLine("Введите количество строк треугольника Паскаля");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    for (int space = 0; space <= (number - i); space++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" ");
        Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));
    }
    Console.WriteLine();
}

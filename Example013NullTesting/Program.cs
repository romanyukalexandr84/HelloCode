Console.WriteLine ("Введите целое исло");
int a = int.Parse (Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine ("Число кратно одновремено 7 и 23");
}
else
{
    Console.WriteLine ("Число не кратно одновремено 7 и 23");
}
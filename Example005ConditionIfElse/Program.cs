Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же САША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
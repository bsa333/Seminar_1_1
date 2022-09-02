Console.Write("Введите имя пользоваателя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это жа Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
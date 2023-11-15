Console.Write("Введите имя ползователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "shampo")
{
    Console.WriteLine("Ура, привет!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
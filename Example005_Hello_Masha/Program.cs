Console.Write("Введите имя пользователя");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша") // ToLower - переводит все буквы в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}

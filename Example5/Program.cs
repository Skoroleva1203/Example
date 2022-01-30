Console . Write ( " Введите имя пользователя: " );
string username = Console.ReadLine();

if(username.ToLower() == "светлана")
{
    Console . WriteLine ( " Ура, это же Светлана! " );
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

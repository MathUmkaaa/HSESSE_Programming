class Program
{
    static void Main()
    {
        // запрос имени и считывание данных с консоли
        Console.Write("Введите имя: ");
        string? name = Console.ReadLine();

        // приветствие пользователя по имени :)
        Console.WriteLine($"Здравствуйте, {name}!");
    }
}
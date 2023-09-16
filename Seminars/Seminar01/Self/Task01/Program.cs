class Program
{
    static void Main()
    {      
        // считывание данных с консоли
        string? surname = Console.ReadLine();
        string? name = Console.ReadLine();
        string? fathers_name = Console.ReadLine();

        // вывод  данных на консоль в три строки
        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Отчество: {fathers_name}");
    }
}

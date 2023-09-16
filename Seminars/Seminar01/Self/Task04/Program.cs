class Program
{
    static void Main()
    {
        // изменение заливки текста
        Console.BackgroundColor = ConsoleColor.Blue;

        // изменение цвета текста
        Console.ForegroundColor = ConsoleColor.Yellow;

        // запрос имени и считывание данных с консоли
        Console.Write("Введите имя: ");
        string? name = Console.ReadLine();

        // изменение заливки текста
        Console.BackgroundColor = ConsoleColor.Green;

        // изменение цвета текста
        Console.ForegroundColor = ConsoleColor.White;


        // приветствие пользователя по имени :)
        Console.WriteLine($"Здравствуйте, {name}!");


        // сброс настроек цвета текста
        Console.ResetColor();
    }
}
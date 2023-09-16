class Program
{
    static void Main()
    {
        // считывание данных с консоли
        string? surname = Console.ReadLine();
        string? name = Console.ReadLine();
        string? fathers_name = Console.ReadLine();

        // вывод  данных на консоль в одну строку
        Console.WriteLine($"{surname} {name} {fathers_name}");
    }
}
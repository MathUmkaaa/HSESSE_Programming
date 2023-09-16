class Program
{
    static void Main()
    {

        // инициализируем переменные, используем double для увеличения точности расчётов в случае введения дробных значений
        double U, R;


        // считывание данных с консоли
        U = double.Parse(Console.ReadLine());
        R = double.Parse(Console.ReadLine());


        Console.WriteLine(U/R);
        Console.WriteLine(Math.Pow(U, 2) / R);


    }
}
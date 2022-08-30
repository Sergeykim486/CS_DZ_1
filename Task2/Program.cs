try
{
    Console.WriteLine("Введите первое целое число...");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое число...");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a>=b)
        Console.WriteLine("максимальное число: "+a);
    else
        Console.WriteLine("максимальное число: "+b);
}

catch
{
    Console.WriteLine("Вы ввели не целое число!!!");
}
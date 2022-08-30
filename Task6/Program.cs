try
{
    Console.WriteLine("Введите целое число...");
    int a = Convert.ToInt32(Console.ReadLine());
    int x = a%2;
    if (x == 0)
        Console.WriteLine("Да.");
    else
        Console.WriteLine("Нет.");
}

catch
{
    Console.WriteLine("Вы ввели не целое число!!!");
}
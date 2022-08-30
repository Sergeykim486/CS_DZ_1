try
{
    Console.WriteLine("Введите целое число...");
    int a = Convert.ToInt32(Console.ReadLine());
    int x = a%2;
    if (x == 0)
        Console.WriteLine("Да. Число является четным.");
    else
        Console.WriteLine("Нет. Число не является четным.");
}

catch
{
    Console.WriteLine("Вы ввели не целое число!!!");
}
try
{
    Console.WriteLine("Введите целое число...");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 1;

    Console.WriteLine("\nВСЕ ЧЕТНЫЕ ЧИСЛА ОТ ДО "+N+":");

    while (i <= N)
    {
        int x = i%2;
        if (x == 0)
        {
            Console.Write(i+", ");
        }
        i++;
    }

    Console.WriteLine("\n");
}

catch
{
    Console.WriteLine("Вы ввели не целое число!!!");
}
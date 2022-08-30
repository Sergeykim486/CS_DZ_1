try
{
        Console.WriteLine("Сколько чисел сравниваем?");
        int n = Convert.ToInt32(Console.ReadLine());
        int [] numbers = new int[n];
        int i = 0;
        int max = 0;
    
        while (i<n)
        {
            int a = i + 1;
            Console.WriteLine("Введите целое число №"+a);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        i = 1;
        while (i<n)
        {
            if (numbers[i] > numbers[max])
            {
                max = i;
            }
            i++;
        }

        Console.WriteLine("Максимальное число: "+numbers[max]);
}

catch
{
    Console.WriteLine("Вы ввели не целое число!!!");
}
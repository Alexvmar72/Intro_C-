// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите магическое число N");
int n = int.Parse(Console.ReadLine()!);

if (n > 1)
{
    if (n >= 4)
    {
        Console.Write("2");
        for (int i = 4; i <= n; i = i + 2)
        {
            Console.Write(", " + i);
        }
    }

    else
    {
        Console.WriteLine("2");
    }
}

else
{
    Console.WriteLine("Необходимо перезапустить программу и ввести число больше 1");
}



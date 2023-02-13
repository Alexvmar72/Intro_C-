// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите магическое число N");
int a = int.Parse(Console.ReadLine()!);

if (a > 1)
{
    for (int i = 2; i <= a; i = i + 2)
    {
        if (a >= 4)
        {
            Console.Write(i + " ");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Необходимо перезапустить программу и ввести число больше 1");
}



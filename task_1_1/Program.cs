// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите любые три числа ниже");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (max < b)
{
    max = b;
}

if (max < c)
{
    max = c;
}

Console.Write("Максимальное из всех трёх чисел: ");
Console.WriteLine(max);
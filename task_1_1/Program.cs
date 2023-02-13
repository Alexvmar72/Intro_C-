// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите любые три числа ниже");
Console.Write("Введите A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите C: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (max < b)
{
    max = b;
}

else if (max < c)
{
    max = c;
}

Console.Write("Максимальное из трёх чисел: ");
Console.WriteLine(max);
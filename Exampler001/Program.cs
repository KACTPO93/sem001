// Программа проверяющая является ли 2 число квадратом 1
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число квадрат первого: ");
int b = int.Parse(Console.ReadLine());
int sqr = a * a;
if (b == sqr)
    {
    Console.WriteLine("Правильно!");
    }
        else
        {Console.WriteLine("Не правильно!");
        }
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Add a Number:");
int number = int.Parse(Console.ReadLine());

void LineNumbers(int n)
{
    if (n!=1) 
    {
        Console.Write($"{n}, ");
        LineNumbers(n-1);
    }
    else Console.Write($"{n}");
}

LineNumbers(number);
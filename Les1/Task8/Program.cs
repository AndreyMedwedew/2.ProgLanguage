// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("add number: ");

int N = int.Parse(Console.ReadLine());
for (int i = 1; i < N + 1; i += 1)
{
    if(i % 2 == 0) Console.Write(i + ", ");
}
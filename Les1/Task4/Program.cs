// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("add number: "); 
int max = int.Parse(Console.ReadLine());
Console.Write("add second number: "); 
int b = int.Parse(Console.ReadLine());
Console.Write("add third number: "); 
int c = int.Parse(Console.ReadLine());
if (max < b) max = b;
if (max < c) max = c;
Console.Write("max number is: "); 
Console.WriteLine(max);

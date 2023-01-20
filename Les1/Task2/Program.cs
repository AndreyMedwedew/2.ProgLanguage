// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("add number: "); 
int a = int.Parse(Console.ReadLine());
Console.Write("add second number: "); 
int b = int.Parse(Console.ReadLine());
Console.Write("max number is: "); 
if (a > b) Console.WriteLine(a);
else Console.WriteLine(b);

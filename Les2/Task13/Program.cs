// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int N = int.Parse(Console.ReadLine());
if (N<100)  Console.Write("number does not have a third digit");
else 
{
while (N>=1000)
{
N /= 10;
}
N %= 10;
Console.WriteLine($"a third digit is {N}");
}

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int num = int.Parse(Console.ReadLine());
int a = num / 10000;
int b = num / 1000 % 10;
int c = num / 10 % 10;
int d = num % 10;

// Console.Write($"{a}, {b}, {c}, {d}");


if (a == d & b == c) Console.Write("Yes");
else Console.Write("No");

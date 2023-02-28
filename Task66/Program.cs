// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Add a StartNumber:");
int StartNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Add a FinishNumber:");
int FinishNumber = int.Parse(Console.ReadLine());

int SumNumbers(int m, int n)
{   
    if(n == m) return n;

    else return n += SumNumbers(m, n - 1);
}

Console.Write(SumNumbers(StartNumber, FinishNumber));
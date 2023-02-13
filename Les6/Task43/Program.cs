// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());

void xy(double b1, double k1, double b2, double k2) 
{
    double x = (b2-b1) / (k1-k2);
    double y = k1*x+b1;
    Console.Write($"{x}, {y}"); 
}

xy(b1, k1, b2, k2);

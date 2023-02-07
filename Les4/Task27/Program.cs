// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int x1 = int.Parse(Console.ReadLine());
void kub_chisla(int a)
{
int sum=0;
while (a>10)
{
sum += a%10;
a /= 10;
}
Console.Write(sum+a);
}

kub_chisla(x1);

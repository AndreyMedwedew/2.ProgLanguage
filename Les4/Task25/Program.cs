// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());


void kub_chisla(int a, int b)
{   
    int res = 1;
    for(int i = 1; i <= b; i += 1)
    {
        res*=a;
    }
    Console.Write(res);
}

kub_chisla(x1, y1);

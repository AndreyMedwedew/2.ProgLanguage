// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double [,] GetArray(int m, int n)
{    
    double[,] a = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        }
    }
    return a;
}


void PrintArray(double[,] inArray) 
    {
        for (int i=0;i<inArray.GetLength(0);i+=1) 
        {
            for (int j=0; j<inArray.GetLength(1); j+=1) 
            {
                Console.Write($"{inArray[i,j]} ");
            }
            Console.WriteLine();
        }
    }

int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

PrintArray(GetArray(rows, columns));


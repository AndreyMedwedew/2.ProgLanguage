// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Math;

int [,] GetArray(int m, int n, int minval, int maxval) 
{
    int [,] result = new int[m,n];
    for(int i=0; i<m; i+=1) 
    {
        for(int j=0; j<n; j+=1) 
        {
            result[i,j] = new Random().Next(minval, maxval+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) 
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

void GetResultArray(int[,] array) 
{
    double [] result = new double[array.GetLength(1)];
    for(int j=0;j<array.GetLength(1);j+=1) 
    {
        int sum=0;
        for (int i=0;i< array.GetLength(0);i+=1) 
        {
            sum+=array[i,j];
        }
        result[j] = Math.Round(Convert.ToDouble(sum)/Convert.ToDouble(array.GetLength(0)), 2);
    }
    for(int k=0; k<result.GetLength(0); k+=1) Console.Write($"{result[k]} ");
}

// int rows = int.Parse(Console.ReadLine());
// int columns = int.Parse(Console.ReadLine());
// int minval = int.Parse(Console.ReadLine());
// int maxval = int.Parse(Console.ReadLine());

int [,] array = GetArray(4, 5, 0, 100);
PrintArray(array);
Console.WriteLine();
GetResultArray(array);

// GetArray(rows, columns, minval, maxval);
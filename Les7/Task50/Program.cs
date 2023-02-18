// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

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

// int rows = int.Parse(Console.ReadLine());
// int columns = int.Parse(Console.ReadLine());
// int minval = int.Parse(Console.ReadLine());
// int maxval = int.Parse(Console.ReadLine());

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

void the_presence_of_an_element(int a, int b, int[,] array) 
{
    if (a<=array.GetLength(0) && b<=array.GetLength(1)) Console.Write(array[a,b]);
    else Console.Write("no such element");
}
int [,] res = GetArray(4,5,0,100);
PrintArray(res);
the_presence_of_an_element(1,97, res);

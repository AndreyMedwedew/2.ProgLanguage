// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 9, 9, 0,
// 2, 8, 0, 9
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
Console.Clear();

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
                if (inArray[i, 1] != 0)
                {
                    Console.Write($"{inArray[i,j]} ");
                    // Console.Write($"{i} встречается {inArray[i,1]} раз(а)");
                }
            }
            Console.WriteLine();
        }
    }

void PrintArrayRes(int[,] inArray) 
    {
        for (int i=0;i<inArray.GetLength(0);i+=1) 
        {
                if (inArray[i, 1] != 0)
                {
                    // Console.Write($"{inArray[i,j]} ");
                    Console.Write($"{i} встречается {inArray[i,1]} раз(а)");
                }
            Console.WriteLine();
        }
    }




int[,] NumberDict(int [,] inarray)
{
    int [,] Numbers = new int[,] { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 },
                               { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 } };

    for(int i = 0; i < inarray.GetLength(0); i += 1)
    {
        for(int j = 0; j < inarray.GetLength(1); j += 1)
        {
            int a = inarray[i, j];
            Numbers[a, 1] = Numbers[a, 1] + 1;
        }
    }
    return Numbers;
}


int [,] array2d = GetArray(2, 4, 0, 9);
PrintArray(array2d);
Console.WriteLine();
int [,] array2d2 = NumberDict(array2d);
PrintArrayRes(array2d2);
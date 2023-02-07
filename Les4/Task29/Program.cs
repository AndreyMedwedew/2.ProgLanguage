// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size) 
{
    int[] array = new int[size];
    for(int i=0;i<array.Length;i+=1) 
    {
        array[i] = new Random().Next(-99,100); 
    }
    return array; 
}

void PrintArray(int[] array) 
{
    for(int i=0; i<array. Length-1;i+=1) 
    {
        Console.Write(array[i]+", "); 
    }
    Console.Write(array[7]+"."); 
}

PrintArray(CreateArray(8));

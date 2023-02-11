// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArray(int size) 
{
    int[] array = new int[size];
    for(int i=0;i<array.Length;i+=1) 
    {
        array[i] = new Random().Next(100,1000); 
    }
    return array; 
}

void PrintArray(int[] array) 
{
    for(int i=0; i<array.Length;i+=1) 
    {
        Console.Write(array[i]+", "); 
    }
}

void sumnechetindex(int[] array) 
{
    int count=0;
    for(int i=0; i<array. Length;i+=1) 
    {
        if(i%2==0) count += array[i];
    }
    Console.Write(count); 
}

int[] res = CreateArray(8);

PrintArray(res);
Console.WriteLine(res);

sumnechetindex(res);

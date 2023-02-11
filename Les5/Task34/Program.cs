// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int size) {
    int[] array = new int[size];
    for(int i=0;i<array.Length;i+=1) 
    {
        array[i] = new Random().Next(100,1000); }
return array; }

void PrintArray(int[] array) 
{
    for(int i=0; i<array.Length;i+=1) 
    {
        Console.Write(array[i]+", "); 
    }
}

int[] res = CreateArray(8);

void countchetnumbers(int[] array) 
{
    int count=0;
    for(int i=0; i<array. Length;i+=1) 
    {
        if(array[i]%2==0) count +=1;
    }
    Console.Write(count); 
}

// countchetnumbers(CreateArray(8));

PrintArray(res);
Console.WriteLine();
countchetnumbers(res);


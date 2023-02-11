// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArray(int size) 
{
    double [] array = new double [size];
    for(int i=0;i<array.Length;i+=1) 
    {
        array[i] = new Random().Next(100,1000); 
    }
    return array; 
}

void PrintArray(double[] array) 
{
    for(int i=0; i<array.Length;i+=1) 
    {
        Console.Write(array[i]+", "); 
    }
}

void diffmaxmin(double [] array) 
{
    double max=0;
    double min=1000000;
    for(int i=0; i<array. Length;i+=1) 
    {
        if(array[i]>max) max = array[i];
        if(array[i]<min) min = array[i];
    }
Console.Write(max-min); 
}

// diffmaxmin(CreateArray(8));

// PrintArray(CreateArray(6));

double [] res = {3.0, 7.1, 22.5, 2.7, 78.8};

diffmaxmin(res);
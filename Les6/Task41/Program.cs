// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("how many numbers do you want to enter");
int x1 = int.Parse(Console.ReadLine());

int[] CreateArray(int size) 
{
    int[] array = new int[size];
    for(int i=0;i<array.Length;i+=1) 
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array; 
}

void numbersgreaterthanzero (int[] array) 
{
    int count=0;
    for(int i=0; i<array. Length;i+=1) 
    {
        if(array[i]>0) count += 1;
    }
    Console.Write(count); 
}

numbersgreaterthanzero(CreateArray(x1));

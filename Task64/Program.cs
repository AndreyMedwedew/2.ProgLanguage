
// void LineNumbers(int n)
// {
//     if (n!=1) LineNumbers(n-1);
//     Console.Write($"{n} ");
// }

Console.Clear();
Console.WriteLine("Add a Number:");
int number = int.Parse(Console.ReadLine());

void LineNumbers(int n)
{
    if (n!=1) 
    {
        Console.Write($"{n}, ");
        LineNumbers(n-1);
    }
    else Console.Write($"{n}");
}

LineNumbers(number);
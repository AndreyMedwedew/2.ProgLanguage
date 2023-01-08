
Console.Clear();
Console.WriteLine("Add a StartNumber:");
int StartNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Add a FinishNumber:");
int FinishNumber = int.Parse(Console.ReadLine());

void SumNumbers(int m, int n)
{
    int sum = 0;
    int i = 0;
    for(i=m; i<n+1; i+=1) sum+=i;
    // return sum;
    Console.Write($"SumNumbers from {m} to {n} is {sum}");
}

SumNumbers(StartNumber, FinishNumber);
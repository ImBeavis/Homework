Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.Write ($"{N} -> ");
while (i <= N)
    if (i % 2 == 0)
    {
        Console.Write ($"{i} ");
        i = i + 2;
    }
    else
    {
        i = i + 1;
    }
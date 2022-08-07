Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (i <= N);
    if (i % 2 == 0)
    {
        Console.Write ($"{N} -> ");
        Console.Write (i);
        i = i + 2;
    }
    else
    {
        i = i + 1;
    }
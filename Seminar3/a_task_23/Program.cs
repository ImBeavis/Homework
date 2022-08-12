Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"{n} -> ");
for (int i = 1; i <= n; i++)
{
    double num = Math.Pow(i, 3);
    Console.Write($"{num} ");
}
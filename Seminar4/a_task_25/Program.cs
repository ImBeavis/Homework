Console.Write("Введите число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите степень возведения: ");
int numB = int.Parse(Console.ReadLine());

int Exponentiate(int a, int b)
{
    int sum = 1;
    for (int i = 1; i <= b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

Console.Write($"{numA} в степени {numB} -> {Exponentiate(numA, numB)}");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Sum(int a)
{
    int result = 0;
    while (a > 0)
    {
        result = a % 10 + result;
        a /= 10; 
    }
    return result;
}  
Console.Write(Sum(num));
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
while (number > 999)
{
    number = number / 10;
}
    if (number > 99)
    {
        number = number % 10;
        Console.Write(number);
    }
    else 
    {
        Console.Write("Третьей цифры нет");
    }
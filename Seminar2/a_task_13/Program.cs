Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
while (number > 99)
{
    number = number % 10;
    Console.Write(number);
}
Console.Write("Третьей цифры нет");
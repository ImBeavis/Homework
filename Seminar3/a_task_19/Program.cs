Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int arg1 = number % 10;
int arg2 = number / 10000;
int arg3 = number % 10000 / 1000;
int arg4 = number % 100 /10;
if (number % 100000 == number)
    if(arg1 == arg2 && arg3 == arg4)
    {
        Console.Write($"{number} -> Да");
    }
    else 
    {
        Console.Write($"{number} -> Нет");
    }
else 
{
    Console.Write("Неверное значение!");
}
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int a1 = number / 100;
int a2 = number / 10;
int a3 = number % 10;
int result = a2 - (a1 * 10);
Console.Write(result);
Console.Write("Введите число обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.Write("Нет");
}
else 
{
    Console.Write("Да");
}
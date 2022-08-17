Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон чисел от: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон чисел до: ");
int b = int.Parse(Console.ReadLine());

Console.Write($"Массив размером {num} символов, заполненый числами в диапазоне от {a} до {b}: ");

void PrintArray()
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
        Console.Write($"{arr[i]} ");
    }
}
PrintArray();
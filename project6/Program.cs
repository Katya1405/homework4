// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.


void fillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Задайте размер массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
int product = 1;

fillArray(array, -100, 100);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length / 2)
    {
        product = array[i] * array[n - 1];
        Console.WriteLine($"Пара {array[i]} * {array[n - 1]} = {product}");
        n--;
    }
}
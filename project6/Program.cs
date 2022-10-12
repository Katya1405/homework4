// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Задайте размер массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
int product = 1;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length / 2)
    {
        product = array[i] * array[n - 1];
        n--;
        Console.WriteLine("Произведение пары = " + product);
    }
}
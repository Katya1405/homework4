// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.WriteLine("Задайте размер массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
    if (i % 2 == 1) sum += array[i];
}
Console.WriteLine();
Console.WriteLine("Сумма чисел массива, стоящих на нечетной позиции= " + sum);
// Найти сумму чисел одномерного массива стоящих на нечетной позиции


void fillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum += array[i];
    }
    return sum;
}

Console.WriteLine("Задайте размер массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[n];

fillArray(array, -100, 100);
printArray(array);
int sum = SumNumbers(array);

Console.WriteLine();
Console.WriteLine("Сумма чисел массива, стоящих на нечетной позиции= " + sum);
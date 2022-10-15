// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел.
// countEven - количество четных чисел
// count Odd - колво нечетных

void fillArray(int[] arraychik, int min, int max)
{
    for (int i = 0; i < arraychik.Length; i++)
        arraychik[i] = new Random().Next(min, max);
}

void printArray(int[] arraychik)
{
    for (int i = 0; i < arraychik.Length; i++)
        Console.Write(arraychik[i] + " ");
}

int n = new Random().Next(1, 15);
Console.WriteLine("Размерность массива: " + n);
int[] arraychik = new int[n];

fillArray(arraychik, 100, 1000);
printArray(arraychik);

int countEven = 0;
int countOdd = 0;

for (int i = 0; i < arraychik.Length; i++)
{
    if (arraychik[i] % 2 == 0)
        countEven++;
    else countOdd++;
}

Console.WriteLine();
Console.WriteLine("Количество четных чисел в данном массиве: " + countEven);
Console.WriteLine("Количество нечетных чисел в данном массиве: " + countOdd);
// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел.
// countEven - количество четных чисел
// count Odd - колво нечетных


int n = new Random().Next(1, 15);
Console.WriteLine("Размерность массива: " + n);
int[] arraychik = new int[n];
int countEven = 0;
int countOdd = 0;
for (int i = 0; i < arraychik.Length; i++)
{
    arraychik[i] = new Random().Next(100, 1000);
    Console.Write(arraychik[i] + " ");
    if (arraychik[i] % 2 == 0) countEven++;
    else countOdd++;
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел в данном массиве: " + countEven);
Console.WriteLine("Количество нечетных чисел в данном массиве: " + countOdd);
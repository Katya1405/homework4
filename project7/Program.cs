// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = { -17.6, 4.245, 99.42, 8, -9.38 };
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    else if (array[i] > max) max = array[i];
}
Console.WriteLine("Максимальный элемент в массиве: " + max);
Console.WriteLine("Минимальный элемент в массиве: " + min);
double result = max - min;
Console.WriteLine("Разница между max и min элементами = " + result);
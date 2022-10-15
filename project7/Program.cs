// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

float[] array = { -17.6f, 4.245f, 99.42f, 8, -9.38f };
float min = array[0];
float max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
    else if (array[i] > max) 
        max = array[i];
}
Console.WriteLine("Максимальный элемент в массиве: " + max);
Console.WriteLine("Минимальный элемент в массиве: " + min);
float result = max - min;
Console.WriteLine("Разница между max и min элементами = " + Math.Round(result,2));
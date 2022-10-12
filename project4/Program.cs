// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arrayushka = new int[123];
int count = 0;
for (int i = 0; i < arrayushka.Length; i++)
{
    arrayushka[i] = i + 1;
    Console.Write(arrayushka[i] + " ");
    if (arrayushka[i] >= 10 && arrayushka[i] <= 99) count++;
}
Console.WriteLine();
Console.WriteLine("В данном массиве из отрезка [10,99] присуствует " + count + " чисел");
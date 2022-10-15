// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


void fillArray(int[] arrayushka)
{
    for (int i = 0; i < arrayushka.Length; i++)
        arrayushka[i] = i + 1;
}

void printArray(int[] arrayushka)
{
    for (int i = 0; i < arrayushka.Length; i++)
        Console.Write(arrayushka[i] + " ");
}

int Count(int[] arrayushka)
{
    int count = 0;
    for (int i = 0; i < arrayushka.Length; i++)
    {
        if (arrayushka[i] >= 10 && arrayushka[i] <= 99)
            count++;
    }
    return count;
}

int[] arrayushka = new int[123];

fillArray(arrayushka);
printArray(arrayushka);
int count = Count(arrayushka);

Console.WriteLine();
Console.WriteLine($"В данном массиве из отрезка [10,99] присуствует {count} чисел");
// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

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

int n = 8;
int[] array = new int[n];

fillArray(array, 0, 2);
printArray(array);


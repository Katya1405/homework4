// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

// sumPos - сумма положительных элементов
// sumNeg - сумма отрицательных элементов 

void fillArray(int[] myArray, int min, int max)
{
    for (int i = 0; i < myArray.Length; i++)
        myArray[i] = new Random().Next(min, max);
}

void printArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
        Console.Write(myArray[i] + " ");
}

int[] myArray = new int[12];
int sumPos = 0;
int sumNeg = 0;

fillArray(myArray, 0, 10);
printArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
        sumPos += myArray[i];
    else sumNeg += myArray[i];
}
Console.WriteLine();
Console.WriteLine("Сумма положительных элементов данного массива: " + sumPos);
Console.WriteLine("Сумма отрицательных элементов данного массива: " + sumNeg);
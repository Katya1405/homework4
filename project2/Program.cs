// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

// sumPos - сумма положительных элементов
// sumNeg - сумма отрицательных элементов 

int[] myArray = new int[12];
int sumPos = 0;
int sumNeg = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(0, 10);
    Console.Write(myArray[i] + " ");
    if (myArray[i] > 0) sumPos += myArray[i];
    else sumNeg += myArray[i];
}
Console.WriteLine();
Console.WriteLine("Сумма положительных элементов данного массива: " + sumPos);
Console.WriteLine("Сумма отрицательных элементов данного массива: " + sumNeg);
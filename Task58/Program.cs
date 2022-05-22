// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplicationArray(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int m = 0; m < arrayB.GetLength(0); m++)
            {
                arrayC[i, j] += arrayA[i, m] * arrayB[m, j];
            }
        }
    }
    return arrayC;
}

int[,] arrayA = new int[4, 5];
int[,] arrayB = new int[5, 3];
FillArrayRandom(arrayA);
FillArrayRandom(arrayB);
System.Console.WriteLine("Массив заполненный рандомными значениями:");
PrintArray(arrayA);
System.Console.WriteLine();
PrintArray(arrayB);
System.Console.WriteLine();
PrintArray(MultiplicationArray(arrayA, arrayB));
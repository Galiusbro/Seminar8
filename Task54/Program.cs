// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

void SortArrayDescending(int[,] array)
{
    int number = array[0, 0];
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    number = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = number;
                }
            }
        }
    }

}


int[,] array = new int[3, 16];
FillArrayRandom(array);
System.Console.WriteLine("Массив заполненный рандомными значениями:");
PrintArray(array);
System.Console.WriteLine();


System.Console.WriteLine("Массив после обработки:");
SortArrayDescending(array);
PrintArray(array);
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Вывод по форме: -> вторая строка


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

int MinLine(int[,] array)
{
    int controlSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        controlSum += array[0, j];
    }
    int sum = 0;
    int minLineIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        System.Console.WriteLine("Сумма строки = " + sum);
        if (sum < controlSum)
        {
            minLineIndex = i;
            controlSum = sum;
        }
        sum = 0;
    }
    System.Console.WriteLine();
    return minLineIndex;
}

void PrintResult(int minLineIndex)
{
    switch (minLineIndex)
    {
        case 0: System.Console.WriteLine("первая строка"); break;
        case 1: System.Console.WriteLine("вторая строка"); break;
        case 2: System.Console.WriteLine("третья строка"); break;
        case 3: System.Console.WriteLine("четвертая строка"); break;
        case 4: System.Console.WriteLine("пятая строка"); break;
        case 5: System.Console.WriteLine("шестая строка"); break;
        case 6: System.Console.WriteLine("седьмая строка"); break;
        case 7: System.Console.WriteLine("восьмая строка"); break;
        case 8: System.Console.WriteLine("девятая строка"); break;
        case 9: System.Console.WriteLine("десятая строка"); break;
        default:
            System.Console.WriteLine($"{minLineIndex + 1}-я строка");
            break;
    }
}


int[,] array = new int[4, 4];
FillArrayRandom(array);
System.Console.WriteLine("Массив заполненный рандомными значениями:");
PrintArray(array);
System.Console.WriteLine();

PrintResult(MinLine(array));
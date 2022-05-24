// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void FillArrayRandom(int[,,] array)
{
    int a = -99;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = a++;
                System.Console.WriteLine($"a[{i}, {j}, {k}] = {array[i, j, k]}");
                if (a == -9) a=10;
                if (a == 100) break;             
            }

        }
    }
}


int[,,] array = new int[4, 9, 5];
FillArrayRandom(array);

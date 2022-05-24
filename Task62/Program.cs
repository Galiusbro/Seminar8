// Заполните спирально массив 4 на 4.


void FillArrayRandom(int[,] array, int n, int m)
{
    int row = 0;
    int col = 0;
    int x = 1;
    int y = 0;
    int count = 0;
    int visits = m;

    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = m * (count % 2) + n * ((count + 1) % 2) - (count / 2 - 1) - 2;
            int temp = x;
            x = -y;
            y = temp;
            count++;
        }

        col += x;
        row += y;
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


const int n = 4;
const int m = 4;
int[,] array = new int[n, m];
FillArrayRandom(array, n, m);
PrintArray(array);
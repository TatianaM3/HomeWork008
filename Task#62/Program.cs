//Напишите программу, которая заполнит спирально массив 4 на 4

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int row = 4;
int column = 4;
int[,] array = new int[row, column];
int k = 01;

for (int j = 0; j < array.GetLength(1); j++)
{
    array[0, j] = k;
    k++;
}

for (int i = 1; i < array.GetLength(0); i++)
{
    array[i, array.GetLength(1) - 1] = k;
    k++;
}

for (int j = 2; j >= 0; j--)
{
    array[array.GetLength(0) - 1, j] = k;
    k++;
}

for (int i = 2; i > 0; i--)
{
    array[i, 0] = k;
    k++;
}

for (int j = 1; j < array.GetLength(1) - 1; j++)
{
    array[array.GetLength(0) - 3, j] = k;
    k++;
}

for (int j = 2; j > 0; j--)
{
    array[array.GetLength(0) - 2, j] = k;
    k++;
}

PrintArray(array);
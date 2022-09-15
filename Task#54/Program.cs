//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];

    for (int i = 0; i < m; ++i){
        for(int j = 0; j < n; ++j){
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); ++i){
        for(int j = 0; j < array.GetLength(1); ++j){
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, colums,1,10);
PrintArray(result);
Console.WriteLine();


  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      for (int k = j + 1; k < result.GetLength(1); k++)
      {
        if (result[i, j] < result[i, k])
        {
          int temp = result[i, j];
          result[i, j] = result[i, k];
          result[i, k] = temp;
        }
      }
    }
  }
PrintArray (result);


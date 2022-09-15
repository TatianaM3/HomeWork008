// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] array1 = new int[m, n];

    for (int i = 0; i < m; ++i){
        for(int j = 0; j < n; ++j){
            array1[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array1;
}

int[,] GetArray2(int m, int n, int minValue, int maxValue){
    int[,] array2 = new int[m, n];

    for (int i = 0; i < m; ++i){
        for(int j = 0; j < n; ++j){
            array2[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array2;
}

void PrintArray(int[,] result){
    for (int i = 0; i < result.GetLength(0); ++i){
        for(int j = 0; j < result.GetLength(1); ++j){
        Console.Write(result[i,j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Первая матрица: ");
int[,] array1 = GetArray(rows, colums,1,10);
PrintArray(array1);

Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
int[,] array2 = GetArray2(colums,rows,1,10);
PrintArray(array2);

int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

for (int i = 0; i < array3.GetLength(0); ++i){
    for(int j = 0; j < array3.GetLength(1); ++j){
        for(int k = 0; k < array1.GetLength(1); ++k){
            array3[i, j] += array1[i, k] * array2[k, j];
        }
    }
}

Console.WriteLine();
Console.WriteLine("Результат перемножения двух матриц: ");
PrintArray(array3);
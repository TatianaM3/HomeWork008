// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int sum = 0;
int min = colums * 10; // 10 = maxValue
int rowmin = 0;


Console.Write("Сумма каждой строки: ");
for (int i = 0; i < result.GetLength(0); ++i){
        for(int j = 0; j < result.GetLength(1); ++j){
        sum = sum + result[i,j];
    }
    Console.Write(sum + ", ");
    if(sum <= min){
        min = sum;
        rowmin = i + 1;
    }
    sum = 0;
}
Console.WriteLine();
Console.WriteLine(rowmin + "-я - строка с наименьшей суммой элементов");
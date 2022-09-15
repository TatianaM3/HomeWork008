// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int GetArray(int row, int col, int size, int[,,] numbers){
    int res = 0;
    for (int i = 0; i < numbers.GetLength(0); ++i){
        for (int j = 0; j < numbers.GetLength(1); ++j){
            for (int k = 0; k < numbers.GetLength(2); ++k){
                if (i == row && j == col && k == size){
                    continue;
                }
                if( numbers[row, col, size] == numbers[i, j, k]){
                    res = 1;
                    return res;
                }
            }
        }
    }
    return res;
}

Console.WriteLine("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите высоту массива: ");
int t = int.Parse(Console.ReadLine());

int[,,] array = new int [m, n, t];
for (int i = 0; i < array.GetLength(0); ++i){
    for (int j = 0; j < array.GetLength(1); ++j){
        for (int k = 0; k < array.GetLength(2); ++k){
            array[i, j, k] = new Random().Next(10,100);
            int res = GetArray(i, j, k, array);
            while(res == 1){
                array[i, j, k] = new Random().Next(10,100);
                res = GetArray(i, j, k, array);
            }
        }
    }
}

for (int i = 0; i < array.GetLength(0); ++i){
    for (int j = 0; j < array.GetLength(1); ++j){
        for ( int k = 0; k < array.GetLength(2); ++k){
            Console.Write($"{array[i, j, k]} ({i},{j},{k})");
        }
        Console.WriteLine();
    }
}    

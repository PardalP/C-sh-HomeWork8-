Console.Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void FillArray(int[,] array){
//     for (int i =0; i<array.GetLength(0);i++){
//         for (int j =0; j<array.GetLength(1);j++){
//             array[i, j] = new Random().Next(-30, 30);
//         }
//     }
// }

// void Sort(int[,] array)
// {
//     int m = array.GetLength(0); 
//     int n = array.GetLength(1); 

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n - 1; j++)
//         {
//             for (int k = 0; k < n - j - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array){
//     for (int i =0; i<array.GetLength(0);i++){
//         for (int j =0; j<array.GetLength(1);j++){
//             System.Console.Write($"{array[i, j],3} \t");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int [rows, cols];

// FillArray(array);
// PrintArray(array);

// Sort(array);

// Console.WriteLine("Упорядоченный массив:");
// PrintArray(array);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// static int RowSum(int[,] array)
// {
//     int m = array.GetLength(0); 
//     int n = array.GetLength(1); 

//     int minSum = int.MaxValue;
//     int minIndex = -1;

//     for (int i = 0; i < m; i++)
//     {
//         int rowSum = 0;

//         for (int j = 0; j < n; j++)
//         {
//             rowSum += array[i, j];
//         }

//         if (rowSum < minSum)
//         {
//             minSum = rowSum;
//             minIndex = i;
//         }
//     }

//     return minIndex;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j],1} \t");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Введите количество строк:");
// int rows = 4;
// System.Console.WriteLine("Введите количество столбцов:");
// int cols = 4;

// int[,] array = new int[rows, cols];

// FillArray(array);
// PrintArray(array);

// int minIndex = RowSum(array);

// Console.WriteLine("Строка с наименьшей суммой элементов: {0}", minIndex);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j],3} \t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] Multiply(int[,] matrix1, int[,] matrix2)
// {
//     int m1 = matrix1.GetLength(0);
//     int n1 = matrix1.GetLength(1);
//     int m2 = matrix2.GetLength(0);
//     int n2 = matrix2.GetLength(1);

//     if (n1 != m2)
//     {
//         throw new ArgumentException("Невозможно выполнить умножение матриц: неправильные размеры матриц.");
//     }

//     int[,] result = new int[m1, n2];

//     for (int i = 0; i < m1; i++)
//     {
//         for (int j = 0; j < n2; j++)
//         {
//             int sum = 0;

//             for (int k = 0; k < n1; k++)
//             {
//                 sum += matrix1[i, k] * matrix2[k, j];
//             }

//             result[i, j] = sum;
//         }
//     }

//     return result;
// }

// void PrintMatrix(int[,] matrix)
// {
//     int m = matrix.GetLength(0);
//     int n = matrix.GetLength(1);

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix1 = {
//             { 2, 4 },
//             { 3, 2 }
//         };

// int[,] matrix2 = {
//             { 3, 4 },
//             { 3, 3 }
//         };

// PrintArray(matrix1);
// PrintArray(matrix2);

// int[,] result = Multiply(matrix1, matrix2);

// Console.WriteLine("Результирующая матрица:");

// PrintMatrix(result);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// static int[,,] GenerateArray()
// {
//     int[,,] array = new int[2, 2, 2];
//     int num = 10; 

//     for (int i = 0; i < 2; i++)
//     {
//         for (int j = 0; j < 2; j++)
//         {
//             for (int k = 0; k < 2; k++)
//             {
//                 array[i, j, k] = num;
//                 num++;

//                 if (num == 100)
//                 {
//                     num = 10; 
//                 }
//             }
//         }
//     }

//     return array;
// }

// static void PrintArray(int[,,] array)
// {
//     int m = array.GetLength(0); 
//     int n = array.GetLength(1); 
//     int p = array.GetLength(2); 

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < p; k++)
//             {
//                 Console.Write("{0}({1},{2},{3}) ", array[i, j, k], i, j, k);
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] array = GenerateArray();

// PrintArray(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


static void FillSpiralArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1); 

    int num = 1; 
    int row = 0; 
    int col = 0;
    int rowDir = 0; 
    int colDir = 1; 

    while (num <= n * m)
    {
        array[row, col] = num;

        int nextRow = row + rowDir;
        int nextCol = col + colDir;

        if (nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= m || array[nextRow, nextCol] != 0)
        {
            int temp = rowDir;
            rowDir = colDir;
            colDir = -temp;
        }

        row += rowDir;
        col += colDir;
        num++;
    }
}

static void PrintArray(int[,] array)
{
    int n = array.GetLength(0); 
    int m = array.GetLength(1); 

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{0:D2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillSpiralArray(array);

PrintArray(array);

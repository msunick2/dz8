// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// void RankingArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int tempValue = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = tempValue;
//                 }
//             }
//         }
//     }
// }

// void Main()
// {
//     Console.Clear();
//     Console.Write("Введите кол-во строк: ");
//     int row = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите кол-во столбцов: ");
//     int col = int.Parse(Console.ReadLine()!);
//     int[,] ourArray = GetArray(row, col, 1, 99);
//     PrintArray(ourArray);

//     System.Console.WriteLine();

//     RankingArray(ourArray);
//     PrintArray(ourArray);
// }

// Main();



// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 5 2 6 7

// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArrayRedMin(int[,] inArray, int minRow)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         if (i == minRow)
//             Console.ForegroundColor = ConsoleColor.DarkRed;

//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.ForegroundColor = ConsoleColor.White;
//         Console.WriteLine();
//     }
// }

// int[] SummOfRowInArray(int[,] array)
// {
//     int[] summArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int summ = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             summ += array[i, j];
//         }
//         summArray[i] = summ;
//     }
//     return summArray;
// }

// int minInArray(int[] array)
// {
//     int minIndex = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[minIndex] > array[i])
//         {
//             minIndex = i;
//         }
//     }
//     return minIndex;
// }

// void Main()
// {
//     Console.Clear();
//     Console.Write("Введите кол-во строк: ");
//     int row = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите кол-во столбцов: ");
//     int col = int.Parse(Console.ReadLine()!);
//     int[,] ourArray = GetArray(row, col, 1, 9);
//     System.Console.WriteLine();
//     int minSummRowIndex = minInArray(SummOfRowInArray(ourArray));
//     PrintArrayRedMin(ourArray, minSummRowIndex);
//     System.Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {minSummRowIndex + 1}");
// }

// Main();



// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MultiplicationArrays(int[,] arrA, int[,] arrB)
// {
//     int rowArrA = arrA.GetLength(0);
//     int colunmArrA = arrA.GetLength(1);
//     int rowArrB = arrB.GetLength(0);
//     int colunmArrB = arrB.GetLength(1);

//     int[,] multyArr = new int[rowArrA, colunmArrB];

//     for (int i = 0; i < rowArrA; i++)
//     {
//         for (int j = 0; j < colunmArrB; j++)
//         {
//             for (int k = 0; k < rowArrB; k++)
//             {
//                 multyArr[i, j] += arrA[i, k] * arrB[k, j];
//             }
//         }
//     }
//     return multyArr;
// }

// void Main()
// {
//     Console.Clear();
//     Console.Write("Введите кол-во строк матрицы A: ");
//     int rowA = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите кол-во столбцов матрицы A: ");
//     int colA = int.Parse(Console.ReadLine()!);

//     Console.Write("Введите кол-во строк матрицы B: ");
//     int rowB = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите кол-во столбцов матрицы B: ");
//     int colB = int.Parse(Console.ReadLine()!);

//     if (colA != rowB)
//     {
//         System.Console.WriteLine("Произведение матриц невозможно");
//         return;
//     }
//     System.Console.WriteLine("\nМатрица A:\n");
//     int[,] arrayA = GetArray(rowA, colA, 1, 5);
//     PrintArray(arrayA);
//     System.Console.WriteLine("\nМатрица B:\n");
//     int[,] arrayB = GetArray(rowB, colB, 5, 9);
//     PrintArray(arrayB);
//     System.Console.WriteLine("\nМатрица AB:\n");
//     PrintArray(MultiplicationArrays(arrayA, arrayB));

// }

// Main();
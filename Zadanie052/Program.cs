/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] InitRandomMatrix()
{
  Console.WriteLine();
  Console.WriteLine("Сгенерированная случайная матрица");
  Random rnd = new Random();
  int[,] matrix = new int[rnd.Next(3, 6), rnd.Next(3, 6)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    { matrix[i, j] = rnd.Next(0, 10); }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    { Console.Write($"{matrix[i, j]} "); }

    Console.WriteLine();
  }
}

void FindAverageInColumns(int[,] matrix)
{
  // GetLength(0) - возвращает количество строк в матрице, GetLength(1) - возвращает количество столбцов 
  Console.WriteLine("Среднее арифметическое элементов в каждом столбце матрицы это");
  int sumElements = 0;

  for (int j = 0; j < matrix.GetLength(1); j++)  // до количества столбцов
  {
    for (int i = 0; i < matrix.GetLength(0); i++) //до количества строк
    { sumElements = sumElements + matrix[i, j]; }

    Console.Write($"{Math.Round((double)sumElements / (double)matrix.GetLength(0), 1)}; ");  //делим на количество строк
    sumElements = 0;
  }
}

int[,] matrix = InitRandomMatrix();
PrintMatrix(matrix);
Console.WriteLine();
FindAverageInColumns(matrix);

﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не корректное число. Повторите ввод.");
    }
  }

  return result;
}

double[,] InitMatrix(int rows, int columns)
{
  double[,] matrix = new double[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = Math.Round((rnd.NextDouble() * 20 - 10), 1);  //random.NextDouble() * (maximum - minimum) + minimum
    }
  }
  return matrix;
}

void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

int rows = GetNumber("Введите размер m (количество строк массива)");
int columns = GetNumber("Введите размер n (количество столбцов массива)");
double[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);


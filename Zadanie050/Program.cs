/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

int[,] InitRandomMatrix(string message)
{
  Console.WriteLine();
  Console.WriteLine(message);
  Random rnd = new Random();
  int[,] matrix = new int[rnd.Next(5, 10), rnd.Next(5, 10)];
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    { matrix[i, j] = rnd.Next(0, 100); }
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

void FindIsElementExist(int[,] matrix, int addressElementRow, int addressElementColumn)
{
  if (addressElementRow < matrix.GetLength(0) && addressElementColumn < matrix.GetLength(1))
  { Console.WriteLine($"Элемент матрицы с адресом ({addressElementRow},{addressElementColumn}) - это элемент {matrix[addressElementRow, addressElementColumn]}"); }
  else
  { Console.WriteLine($"Элемент матрицы с адресом ({addressElementRow},{addressElementColumn}) - не существует"); }
}

(int, int) GetElementAddress(string message)
{
  Console.WriteLine(message);
  string text = Console.ReadLine()!;
  char[] separators = new char[] { ' ', ',', '.', '/' };
  string[] splitArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
  int elementRow = 0;
  int elementColumn = 0;
  int tempNumber = 0;

  if (int.TryParse(splitArray[0], out tempNumber)) elementRow = tempNumber;
  if (int.TryParse(splitArray[1], out tempNumber)) elementColumn = tempNumber;

  return (elementRow, elementColumn);
}

int[,] matrix = InitRandomMatrix("Сгенерированная случайная матрица");
PrintMatrix(matrix);
Console.WriteLine();
(int addressElementRows, int addressElementColumns) = GetElementAddress("Введите требуемый адрес ячейки одной строкой через запятую или точку");
FindIsElementExist(matrix, addressElementRows, addressElementColumns);

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Write("Введите количество столбцов n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк m: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void NewFillArray(int[,]matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k++)
      {
        if (matr[i, k] < matr[i, k + 1])
        {
          int temp = matr[i, k + 1];
          matr[i, k + 1] = matr[i, k];
          matr[i, k] = temp;
        }
      }
    }
  }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
NewFillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
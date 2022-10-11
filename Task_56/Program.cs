// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

void NumberRowMinSumElements(int[,] matr)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRow += matr[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }

    }
    Console.WriteLine($"с наименьшей суммой элементов: {minSumRow + 1} строка");
}



FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
NumberRowMinSumElements(matrix);

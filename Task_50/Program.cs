// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер строки n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца m: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 6];


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
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

void FindeArray(int[,] matr)
{
    if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrix[n - 1, m - 1]}");
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
FindeArray(matrix);

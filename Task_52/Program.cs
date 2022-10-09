// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов m: ");
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


void NewFillArray(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            avarage = (avarage + matr[i, j]);
        }
        avarage = avarage / n;
        Console.Write($"{(Math.Round(avarage, 2))};  ");
    }

}


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
NewFillArray(matrix);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество столбцов n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк m: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[n, m];
int[,] matrixres = new int[n, m];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 5);
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

FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine();
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);

void MultiMatrixArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrixres[i, j]=0;
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                matrixres[i, j] = matrixres[i, j] + (matrix1[i, k] * matrix2[k, j]);
            }
        }
    }
}

MultiMatrixArray(matrixres);
Console.WriteLine();
PrintArray(matrixres);
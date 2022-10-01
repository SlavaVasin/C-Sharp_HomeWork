//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
Console.Write("Введите число до 8: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($" {array[i]} ");
}


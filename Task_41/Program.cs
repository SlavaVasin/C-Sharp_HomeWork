// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Задайте размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void FillArray(int[] array)  //Вводит пользователь числа
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите число для массива:  ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void CountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"{count} чисел(ла) больше 0 ");

}

FillArray(array);
PrintArray(array);
CountNum(array);
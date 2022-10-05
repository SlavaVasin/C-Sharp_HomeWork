// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];   //определяем кол-во элементов в массиве

void FillArray(int[] collection)    // заполняем массив числами с помощью метода FillArray
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] numbers)      // Выводим на экран
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void CountNum(int[] array) // метод поиска четных чисел
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    Console.WriteLine($"Кол-во четных чисел: {result}");

}



FillArray(array); 
PrintArray(array); 
CountNum(array);
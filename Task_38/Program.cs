// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void FillArrayRandomNumbers(double[] array)   //Заполняем массив вещественных чисел.
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] array)               // Выводим массив
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

double getMin(double[] array)                 // минимальное значение
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++) {
        if(array[i] < min) {
            min = array[i];
        }
    }
    return min;
}

double getMax(double[] array)                  // максимальное значение
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++) {
        if(array[i] > max) {
            max = array[i];
        }
    }
    return max;
}


FillArrayRandomNumbers(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Макс элемент = {getMax(array)}\n");
Console.WriteLine($"мин элемент = {getMin(array)}\n");
Console.WriteLine($"Разница между макс и мин элементов = {(Math.Round(getMax(array) - getMin(array), 3))}\n");
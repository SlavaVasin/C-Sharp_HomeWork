// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 1000)
{
    Console.WriteLine("Вы ввели не верное число ");
}
else if (number >= 100 && number <= 999)
{
    int number2 = number / 10;
    int result = number2 % 10;
    Console.WriteLine($"Вторая цифра: {result}");
}
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("третьей цифры нет ");
}
else if (number >= 100 && number <= 999)
{
    int result = number % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else if (number > 999)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
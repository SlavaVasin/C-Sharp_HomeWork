// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("введит число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int dig = 0;

while (number > 0)
{
    dig = number % 10;
    sum = sum + dig;
    number = number / 10;

}
Console.WriteLine(sum);
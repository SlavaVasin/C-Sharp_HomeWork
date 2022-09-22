// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int rev = 0;

while (num > 0)
{
    int dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
}
if (temp == rev) Console.Write("Это палиндром!");
else Console.Write("Это не палиндром!");


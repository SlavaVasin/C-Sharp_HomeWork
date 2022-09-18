// Напишите программу, которая на вход принимает число и выдаёт, 
//     является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;
Console.WriteLine("Результат: " + result);

if (result == 1)
{
    Console.WriteLine("Число НЕ является четным");
}
else
{
    Console.WriteLine("Число является четным");
}
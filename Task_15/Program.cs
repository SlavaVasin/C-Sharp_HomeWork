// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine("Понедельник - работаем");
else if (num == 2) Console.WriteLine("Вторник - работаем");
else if (num == 3) Console.WriteLine("Среда - работаем");
else if (num == 4) Console.WriteLine("Четверг- работаем");
else if (num == 5) Console.WriteLine("Пятница- работаем");
else if (num == 6) Console.WriteLine("Суббота - отдыхаем))");
else if (num == 7) Console.WriteLine("Воскресенье - отдыхаем))");
else if (num > 7) Console.WriteLine("Закончились дни недели =)");

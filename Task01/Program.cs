﻿// Показать таблицу квадратов чисел от 1 до N.
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()??"0");
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i}*{i}={i*i}");
}

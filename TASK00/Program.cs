﻿// 0. Демонстрация решения
// Напишите программу, которая
// 1. на вход принимает число и выдаёт его квадрат (число
// 2. выдаёт его квадрат (числоумноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// string str = Console.ReadLine();
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");




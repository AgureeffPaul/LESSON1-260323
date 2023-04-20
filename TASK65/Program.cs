﻿// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите целое положительное число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if ((numberN > 0) && (numberM > 0))
    NuturalNumbers(numberM, numberN);
else
    Console.WriteLine("Некорректный ввод!");

void NuturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NuturalNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NuturalNumbers(numM - 1, numN);
    }
    else
    {
        Console.WriteLine($"{numM}");
    }
}

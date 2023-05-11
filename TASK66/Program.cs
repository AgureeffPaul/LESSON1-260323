// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = SumRange(m, n);
        Console.WriteLine("Сумма натуральных элементов: " + sum);
    }
    
    static int SumRange(int start, int end) {
        if (end == start) {
            return end;
        }
        else {
            return start + SumRange(start + 1, end);
        }
    }
}

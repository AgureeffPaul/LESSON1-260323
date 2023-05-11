// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program {
    static void Main(string[] args) {
        int m, n;
        Console.Write("Введите значение m: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение n: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Результат: " + AckermannFunction(m, n));
    }
    
    static int AckermannFunction(int m, int n) {
        if (m == 0) {
            return n + 1;
        }
        else if (n == 0) {
            return AckermannFunction(m - 1, 1);
        }
        else {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}


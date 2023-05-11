// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)  //Проверка на корректность ввода
{
    Console.WriteLine($"Все натуральные числа в промежутке от {N} до 1 :");
    PrintRange(N);
}
else Console.WriteLine("Некорректный ввод!");

void PrintRange(int num)
{
    if (num > 1)
    {
        Console.Write(num + ", ");
        PrintRange(num - 1);
    }
    else
    {
        Console.Write("1");
    }
}

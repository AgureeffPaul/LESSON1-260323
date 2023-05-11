// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumRange(m, n);

Console.WriteLine("Сумма натуральных элементов: " + sum);
    
int SumRange(int start, int end) 
{
    if (end == start) 
    {
    return end;
    }
    else 
    {
    return start + SumRange(start + 1, end);
    }
}


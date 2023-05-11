// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((m > 0) && (n > 0) && (m < n))
{
int sum = SumRange(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: " + sum);
}
else if ((m > 0) && (n > 0) && (m > n))
{
    int m1 = m;
    m = n;
    n = m1;

int sum = SumRange(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: " + sum);
}
else Console.WriteLine("Некорректный ввод! Введено не натуральное число.");

int SumRange(int mM, int nN) 
{
    if (nN == mM) 
    {
    return nN;
    }
    else 
    {
    return mM + SumRange(mM + 1, nN);
    }
}


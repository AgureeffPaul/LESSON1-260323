// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A для возведения его в степень");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B - значение степени числа A");
int b = Convert.ToInt32(Console.ReadLine());

int result = DegreeNumber(a, b);
Console.WriteLine($"Результат операции : {result}");

int DegreeNumber(int numA, int numB)
{
    int res = 1;
    for (int i = 0; i < numB; i++)
    {
        res = res * numA;
    }
    return res;
}
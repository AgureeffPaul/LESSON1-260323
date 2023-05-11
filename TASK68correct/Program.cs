// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(0, 0) = 1
// A(0, 1) = 2
// A(0, 2) = 3
// A(0, 3) = 4
// A(0, 4) = 5
// A(1, 0) = 2
// A(2, 0) = 3
// A(3, 0) = 5
// A(4, 0) = 13
// A(4, 1) = 65533

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0)
{
    Console.WriteLine("Результат: " + AckermannFunction(m, n));
}
else Console.WriteLine("Некорректный ввод");

int AckermannFunction(int mM, int nN)
{
    if (mM == 0)
    {
        return nN + 1;
    }
    else if (nN == 0)
    {
        return AckermannFunction(mM - 1, 1);
    }
    else
    {
        return AckermannFunction(mM - 1, AckermannFunction(mM, nN - 1));
    }
}
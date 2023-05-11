// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат: " + AckermannFunction(m, n));


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



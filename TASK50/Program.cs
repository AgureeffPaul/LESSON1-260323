// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
if (m <= 0)
{
    m = EnterCorrectPlease(m);
}

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    n = EnterCorrectPlease(n);
}

Console.WriteLine("Введите строку искомого элемента");
int mElement = Convert.ToInt32(Console.ReadLine());
if (mElement <= 0)
{
    mElement = EnterCorrectPlease(mElement);
}

Console.WriteLine("Введите столбец искомого элемента");
int nElement = Convert.ToInt32(Console.ReadLine());
if (nElement <= 0)
{
    nElement = EnterCorrectPlease(nElement);
}

int[,] resultArray = CreateArrayMatrix(m, n, -10, 10);
PrintMatrix(resultArray);

bool result = ControlElements(mElement, nElement, m, n);
string res = result ? "Такой элемент есть." : "Такого элемента нет. Попробуйте ещё раз.";
Console.WriteLine();
Console.Write($"{res} ");

if (result == true)
{
    Console.Write($"Его значение : {resultArray[mElement, nElement]}");
}

int EnterCorrectPlease(int corr) // Однозначно правильный ВВОД данных в цикле
{
    Console.WriteLine("Введён неверный параметр. Значение должно быть больше нуля.");
    while (corr <= 0)
    {
        Console.WriteLine("Повторите ввод : ");
        corr = Convert.ToInt32(Console.ReadLine());
    }
    return corr;
}

int[,] CreateArrayMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],8}|");
        }
        Console.WriteLine(" ");
    }
}

bool ControlElements(int mElements, int nElements, int mM, int nN) // Проверка на принадлежность массиву
{
    return mElements < mM && nElements < nN;
}



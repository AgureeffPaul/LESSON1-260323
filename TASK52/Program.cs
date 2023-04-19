// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
PrintMatrix(resultArray);

double[] resultArithmAverage = ArithmeticAverage (resultArray, m, n);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintMatrixResult(resultArithmAverage);

int EnterCorrectPlease(int corr)
{
    Console.WriteLine("Введён неверный параметр. Значение должно быть больше нуля.");
    while (corr <= 0)
    {
        Console.WriteLine("Повторите ввод : ");
        corr = Convert.ToInt32(Console.ReadLine());
    }
    return corr;
}

double[,] CreateArrayMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
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

void PrintMatrix(double[,] matrix)
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

double[] ArithmeticAverage(double[,] matrix, int lines, int columns)
{
    double[] arAverage = new double [columns];
    double resAr = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sumAverage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumAverage += matrix[i, j];
        }
        resAr = Math.Round (sumAverage / lines, 2);
        arAverage [j] = resAr;
    }
    return arAverage;

}

void PrintMatrixResult(double[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        {
            Console.Write($"{matrix[i],7}|");
        }
        Console.Write(" ");
    }
}
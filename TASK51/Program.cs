// Задача 51. Задать двумерный массив и найти сумму элементов, находящихся на главной диагонали

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix (m, n, 1, 10);
PrintMatrix(resultArray);

int result = CountTotalSummInDiagonal (resultArray);
Console.WriteLine($"Сумма ячеек по диагонали : {result}");

int result2 = CountTotalSummInDiagonalFast (resultArray);
Console.WriteLine($"Сумма ячеек по диагонали FAST : {result2}");

int[,] CreateArrayMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next (min, max + 1);
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("    ");
    }
}

int CountTotalSummInDiagonal (int[,] arr)
{
    int totalSumm = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i==j) totalSumm += arr[i,j];
        }
    }
    return totalSumm;

}

int CountTotalSummInDiagonalFast (int[,] arr)
{
    int totalSumm = 0;
    int maxDemention = arr.GetLength(0);
    if (maxDemention > arr.GetLength(1)) maxDemention = arr.GetLength(1);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            totalSumm += arr[j,j];
        }
    return totalSumm;

}
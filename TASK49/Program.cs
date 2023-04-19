// Задача 49. Задать двумерный массив. Найти элементы, у которых оба индекса чётные и заменить эти элементы на их квадраты"

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix (m, n, -10, 10);
PrintMatrix(resultArray);
Console.WriteLine("Модифицированная таблица");

ReplaceToSquares(resultArray);
PrintMatrix(resultArray);

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

void ReplaceToSquares(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i=i+2)
    {
        Console.Write(" ");
        for (int j = 0; j < arr.GetLength(1); j=j+2)
        {
            arr[i,j]*=arr[i,j];
        }
        Console.WriteLine("    ");
    }


}

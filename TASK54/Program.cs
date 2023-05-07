// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

Console.WriteLine("Исходный массив:");
PrintMatrix(arr);

Console.WriteLine("Отсортированный массив:");
int[,] resultArray = SortLinesMaxtoMin(arr);
PrintMatrix(resultArray);

int[,] SortLinesMaxtoMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] temp = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j] = matrix[i, j];
        }
        Array.Sort(temp);
        Array.Reverse(temp);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = temp[j];
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

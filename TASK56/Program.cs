// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arr = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

Console.WriteLine("Исходный массив:");
PrintMatrix(arr);

int result = MinRowSumm (arr);
Console.WriteLine($"Строка с наименьшей суммой элементов - строка номер {result + 1}");


int MinRowSumm(int[,] matrix)
{
    int minSumm = 100;
    int minRowIndex = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSumm = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSumm += matrix[i, j];
        }

        if (rowSumm < minSumm)
        {
            minSumm = rowSumm;
            minRowIndex = i;
        }
    }
    return minRowIndex;
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

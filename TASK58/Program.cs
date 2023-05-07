// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = {
    { 2, 4 },
    { 3, 2 }
};
int[,] matrix2 = {
    { 3, 4 },
    { 3, 3 }
};

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Такие матрицы перемножить нельзя. Попробуйте изменить Ваши данные.");
}
int[,] resultFinal = MatrixMultiplication (matrix1, matrix2);

Console.WriteLine("Матрица №1");
PrintMatrix (matrix1);
Console.WriteLine("Матрица №2");
PrintMatrix (matrix2);
Console.WriteLine("Произведение двух матриц");
PrintMatrix (resultFinal);

int[,] MatrixMultiplication(int[,] matrixX, int[,] matrixY)
{
int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        int sum = 0;

        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum += matrixX[i, k] * matrixY[k, j];
        }

        result[i, j] = sum;
    }
}
return result;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],8}|");
        }
        Console.WriteLine(" ");
    }
}
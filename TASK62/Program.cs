// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];
int count = 1;
int startRow = 0;
int endRow = 3;
int startCol = 0;
int endCol = 3;

while(startRow <= endRow && startCol <= endCol)
{
    for(int i = startCol; i <= endCol; i++)
    {
        array[startRow, i] = count;
        count++;
    }
    startRow++;

    for(int i = startRow; i <= endRow; i++)
    {
        array[i, endCol] = count;
        count++;
    }
    endCol--;

    if(startRow <= endRow)
    {
        for(int i = endCol; i >= startCol; i--)
        {
            array[endRow, i] = count;
            count++;
        }
        endRow--;
    }

    if(startCol <= endCol)
    {
        for(int i = endRow; i >= startRow; i--)
        {
            array[i, startCol] = count;
            count++;
        }
        startCol++;
    }
}

PrintMatrix(array);

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

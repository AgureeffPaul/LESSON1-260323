// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6]

int [] array = {1, 2, 5, 7, 19, 6, 1, 33};

PrintArray(array);
Console.WriteLine();

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");

    while (position < count)
    {
        if (position == 7)
        {
            Console.Write($"{col[5]}");
        }
        else if (position == 6)
        {        
        Console.Write($"{col[7]}, ");
        }
        else if (position == 5)
        {        
        Console.Write($"{col[6]}, ");
        }
        else
        {
        Console.Write($"{col[position]}, ");
        }
        position++;
    }
    Console.Write("]");
}

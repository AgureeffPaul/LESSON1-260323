// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = new int[8]; // 0 1 2 3 4 5 6 7

// System.Console.WriteLine(array[i]);

int [] array = new int [8];

FillArray(array);
Console.WriteLine("Массив, заполненный 0 и 1 :");
PrintArray(array);


void FillArray (int[] userArray)
{
    Random num = new Random();
    for (int i=0; i < userArray.Length; i++)
    {
        userArray[i] = num.Next(0,2);
    }
}

void PrintArray (int[] userArray)
{
    Console.Write("[");
    for (int i=0; i < userArray.Length; i++)
    {
        if (i == userArray.Length-1)
        {
        Console.Write ($"{userArray[i] }");
        }
        else Console.Write ($"{userArray[i] },");
    }
    Console.Write("]");
    Console.WriteLine();
}



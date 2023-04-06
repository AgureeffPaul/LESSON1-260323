// Задача 31.
// Массив из 12 элементов заполненных -9 до 9
// Найти сумму  отрицательных и положительных числе массива


int[] CreateArrayInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    }

    int GetSumNegativeElem(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 0) sum += arr[i];
        }
        return sum;

    }

    int GetSumNPositiveElem(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0) sum += arr[i];
        }
        return sum;

    }


    int[] array = CreateArrayInt(12, -9, 9);
    PrintArray(array);
    int sumNegativeElem = GetSumNegativeElem(array);
    int sumNPositiveElem = GetSumNPositiveElem(array);
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных элементов = {sumNPositiveElem}");
    Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");



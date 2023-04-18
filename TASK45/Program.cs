// Задача 45. Создать поэлементную копию массива.

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CopyArray (int[] copyarr)
{
    int[] resultArray = new int [copyarr.Length];
    for (int i = 0; i < copyarr.Length; i++)
    {
        resultArray[i] = copyarr[i];
    }
    return resultArray;
}

int[] array = CreateArrayInt(12, 1, 99);
Console.WriteLine("Исходный массив :");
PrintArray(array);
int [] newCopyArray = CopyArray (array);
newCopyArray[0]= -1;
Console.WriteLine();
Console.WriteLine("Копия массива :");
PrintArray(newCopyArray);

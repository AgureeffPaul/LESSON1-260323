// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи - 0 и 1.

Console.WriteLine("Введите целое число N");
int userNumber = Convert.ToInt32(Console.ReadLine());

PrintArray (FibboNumbers(userNumber));

int[] FibboNumbers(int num)
{
    int[] fibboArray = new int[num];
    fibboArray[0] = 0;
    fibboArray[1] = 1;

    for (int i = 2; i < num; i++)
    {
        fibboArray[i] = fibboArray[i - 1] + fibboArray[i - 2];
    }
    return fibboArray;
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
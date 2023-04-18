// Задача 42. Перевод десятичного в двоичное число.

Console.WriteLine("Введите целое число");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Двоичное число от числа {userNumber} равно {DecToBin (userNumber)}");

int DecToBin (int num)
{
    int result = 0;
    int count = 1;

    while (num > 0)
    {
        result = result + num % 2 * count;
        count *= 10;
        num /= 2;
    }
    return result;
}
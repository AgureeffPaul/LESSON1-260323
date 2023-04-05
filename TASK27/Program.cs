// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int sumNumbers = InputInt("Введите положительное число : ", 0);

int result = SummNumbers(sumNumbers);
Console.WriteLine(result);

static int InputInt(string prompt, int minValue) // Блок сбора данных с проверкой
{
    Console.Write(prompt);
    int value;
    bool isValidInput = int.TryParse(Console.ReadLine(), out value);

    while (!isValidInput || value < minValue)
    {
        Console.WriteLine($"Введено не положительное число. Пожалуйста, введите число в диапазоне от {minValue} до бесконечности");
        Console.Write(prompt);
        isValidInput = int.TryParse(Console.ReadLine(), out value);
    }

    return value;
}

int SummNumbers(int sumNum)
{
    int count = sumNum;
    int sum = 0;

    while (count > 0)
    {
    sum = sum + count % 10;
    count = count / 10;
    }

    return sum;
}
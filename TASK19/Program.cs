// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int fiveNumbers = InputInt("Введите пятизначное число :", 10000, 99999);

bool result = Palindrom(fiveNumbers);
Console.WriteLine(result ? "Да. Это число - палиндром" : "Нет. Это число - не палиндром");

static int InputInt(string prompt, int minValue, int maxValue) // Блок сбора данных с проверкой
{
    Console.Write(prompt);
    int value;
    bool isValidInput = int.TryParse(Console.ReadLine(), out value);

    while (!isValidInput || value < minValue || value > maxValue)
    {
        Console.WriteLine($"Введено не пятизначное число. Пожалуйста, введите число в диапазоне от {minValue} до {maxValue}.");
        Console.Write(prompt);
        isValidInput = int.TryParse(Console.ReadLine(), out value);
    }

    return value;
}

bool Palindrom(int fiveNum)
{
    int num1 = fiveNum / 10000;
    int num2 = (fiveNum / 1000) % 10;
    int num4 = (fiveNum / 10) % 10;
    int num5 = fiveNum % 10;
    return num1 == num5 && num2 == num4;
}
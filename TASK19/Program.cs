// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите количество знаков палиндрома");
int countNumber = Convert.ToInt32(Console.ReadLine()); 

int num = PowerOfTen (countNumber);
Console.WriteLine(num);

int correctNumber = GetUserData (countNumber);

Console.WriteLine($"Введено число {correctNumber}");

int age = InputInt("Enter your age:", 0, 120);






int GetUserData(int countNum) // Ввод данных с проверкой
{
    int newNumber = Convert.ToInt32(Console.ReadLine());

    while (newNumber < num || newNumber > num * 10)
    {
        Console.WriteLine("Введите пятизначное число для проверки на палиндром");
        newNumber = Convert.ToInt32(Console.ReadLine());
    }
    return newNumber;
}

int PowerOfTen(int n) // Расчет 10 в степени n
{
    int result = 1;

    for (int i = 0; i < n; i++)
    {
        result *= 10;
    }

    return result;
}

static int InputInt(string prompt, int minValue, int maxValue) // Блок сбора данных с проверкой
{
    Console.Write(prompt);
    int value;
    bool isValidInput = int.TryParse(Console.ReadLine(), out value);

    while (!isValidInput || value < minValue || value > maxValue)
    {
        Console.WriteLine($"Invalid input. Please enter a value between {minValue} and {maxValue}.");
        Console.Write(prompt);
        isValidInput = int.TryParse(Console.ReadLine(), out value);
    }

    return value;
}

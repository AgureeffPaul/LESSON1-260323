// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine($"Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите первое число для деления:");
int firstnum = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите второе число для деления:");
int secondnum = int.Parse(Console.ReadLine());

bool result = IsMultipleTwoNumbers (num, firstnum, secondnum);
Console.WriteLine(result ? "Число кратное данным числам" : "Число некратное данным числам");

bool IsMultipleTwoNumbers (int number, int firstNumber, int secondNumber)
{
    return number % firstNumber == 0 && number % secondNumber ==0;
}


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

bool MultipleTwoNumbers (int number, int firstnumber, int secondnumber)
{
    return number % firstnumber ==0 && number % secondNumber;
}


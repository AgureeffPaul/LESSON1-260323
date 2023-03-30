// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number1 == number2 && number2 == number3)
{
    Console.WriteLine($"Все введённые Вами числа равны друг другу"); // Проверка на равенство
}


if (number2 > max)
{
    int max = number2;
}

else if (number3 > max)
{
    int max = number3;
}
else
{
    int max = number1;
}

Console.WriteLine($"Максимальное число : {max}"); // Выводим максимум







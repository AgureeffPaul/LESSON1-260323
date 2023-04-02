// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay < 1 || numDay > 7)
{
    Console.WriteLine("Такого дня недели пока не существует");
}
else
{
    bool result = IsWeekEnd(numDay);
    Console.WriteLine(result ? "Да. Этот день - выходной" : "Нет. Этот день - не выходной");
}


bool IsWeekEnd(int numberDay)
{
    return numberDay == 6 || numberDay == 7;
}

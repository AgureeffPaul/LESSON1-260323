// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine($"Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99 )
{
   Console.WriteLine("Третьей цифры нет"); 
}

else

{
    int newNum = ShowThirdDigit(num);
    Console.WriteLine($"Третья цифра введённого числа : {newNum}");
}

int ShowThirdDigit(int number) // Проверяем остаток от деления в цикле и возвращаем третью цифру
{
    int num1 = number;
    
    while (num1 >= 999 && num1 >=100)
    {
         num1 = num1 / 10;
    }
    int ost = num1 % 10;
    return ost;
}

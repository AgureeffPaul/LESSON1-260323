// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine($"Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 1000)
{
   Console.WriteLine("Вы ввели не трехзначное число"); 
}

else
{
    int newNum = ShowSecondDigit(num);
    Console.WriteLine($"Вторая цифра введённого числа : {newNum}");
}

int ShowSecondDigit(int secondNumber)
{
    int action1 = secondNumber / 10;
    int action2 = action1 % 10;
    
    return action2;

}




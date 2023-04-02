// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int numRandom = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100-999 => {numRandom}");

int newNum = ShowSecondDigit(numRandom);
Console.WriteLine($"Вторая цифра случайного числа : {newNum}");

int ShowSecondDigit(int randomNuber)

{
    int action1 = randomNuber / 10;
    int action2 = action1 % 10;
    
    return action2;

}




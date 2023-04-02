// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8  78/10=7.8
// 12-> 2
// 85 -> 8

int numberRandom = new Random().Next(10, 100);//99+1
Console.WriteLine($"Случайное число из отрезка 10-99 => {numberRandom}");

int firstDigit = numberRandom / 10;
int secondDigit = numberRandom % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
}

else
{
    Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");
}
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int maxDigit1 = Math.Max(firstDigit, secondDigit);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}");


int maxDigit2 = MaxDigit(numberRandom);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int MaxDigit(int numRandom)
{
    int firstDigit5 = numRandom / 10;
    int secondDigit5 = numRandom % 10;
    int maxDigit5 = firstDigit > secondDigit ? firstDigit : secondDigit;

    return maxDigit5;

}


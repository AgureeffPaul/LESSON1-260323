// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8  78/10=7.8
// 12-> 2
// 85 -> 8

int numberRandom = new Random().Next(10,100);//99+1
Console.WriteLine($"Случайное число из отрезка 10-99 => {numberRandom}");

int firstDigit = numberRandom / 10;
int secondDigit = numberRandom % 10;

// if (firstDigit > secondDigit);
// {
// Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");

// }

// else

// {
// Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");  
// }

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}"); 

//Math.Max(firstDigit, secondDigit);

int maxDigit = MaxDigit (numberRandom);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}"); 

int MaxDigit (int numRandom);
{
int firstDigit = numRandom / 10;
int secondDigit = numRandom % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

return MaxDigit;

}


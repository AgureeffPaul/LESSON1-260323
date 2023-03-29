// Ввод трехзначное число, на выходе показать третью цифру этого числа

Console.WriteLine("Введите трехзначное целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int lastNumber =  number % 10;

if (number >=100 && number <=1000)
{
Console.WriteLine($"Последняя цифра числа : {lastNumber}");
}
else
{
    Console.WriteLine($"Число {number} не трехзначное");
}



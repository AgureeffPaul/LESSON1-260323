// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1:");
int firstnum = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int secondnum = int.Parse(Console.ReadLine());

bool result = IfFirstSquareSecond (firstnum, secondnum);

String = result ? ("Одно число является квадратом другого" : "Число не является квадратом другого");

bool IfFirstSquareSecond (int firstNumber, int secondNumber)
{
    return (firstNumber == secondNumber * secondNumber || secondNumber * firstNumber);
}

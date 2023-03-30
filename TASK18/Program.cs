// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
string numQuart = Console.ReadLine();

string result = Quarter(numQuart);
Console.WriteLine(result);

string Quarter(string numQuarter)
{
    if (numQuarter == "1") return "x > 0 ; y > 0";
    if (numQuarter == "2") return "x < 0 ; y > 0";
    if (numQuarter == "3") return "x < 0 ; y < 0";
    if (numQuarter == "4") return "x > 0 ; y < 0";
    return "error";
}

// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


// Console.WriteLine("Введите координаты точки");
// Console.Write("X :");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());

// Console.Write("Y :");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter (xCoordinate, yCoordinate);
// string result = quarter > 0
//                 ? $"Указанные координаты соответствуют четверти -> {quarter}"
//                 : "Введены некорректные координаты";

// Console.WriteLine(result);

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

int Quarter (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

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

double d = Math.Sqrt(5);
double num = 5.09987453;
double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
Console.WriteLine(numRound);

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
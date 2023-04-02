// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

Console.WriteLine("Введите координаты первой точки");
Console.Write("X :");
int xPoint1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y :");
int yPoint1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X :");
int xPoint2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y :");
int yPoint2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(5);
double num = 5.09987565655;
double numRound = Math.Round(num, 2, MidpointRounding.ToZero);

double findDistance = FindDistance(xPoint1, yPoint1, xPoint2, yPoint2);
Console.WriteLine($"Расстояние между точками равно : {findDistance}");


double FindDistance(int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    dist = Math.Round(dist, 2, MidpointRounding.ToZero);
    return dist;
}
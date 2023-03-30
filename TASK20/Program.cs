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

double numRound = Math.Round(dist, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равно : {numRound}");


double Distance (int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return dist;
}
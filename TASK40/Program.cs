// Задача 40. Три стороны вводим, проверяем, может ли быть такой треугольник.

Console.WriteLine("Введите длину первой стороны");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangle(firstSide, secondSide, thirdSide);
string res = result ? "Треугольник с данными сторонами может существовать" : "Треугольник с данными сторонами не существует";
Console.WriteLine (res);

bool IsTriangle (int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}


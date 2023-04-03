// // Задача 22: Напишите программу, которая
// // принимает на вход число (N) и выдаёт таблицу
// // квадратов чисел от 1 до N.


// Console.WriteLine("Введите N");
// int n = Convert.ToInt32(Console.ReadLine()); 



// void Square (int num)
// {
// int count = 1;

//  while (coutn < n){
//         int numberN = Math.Sqrt(n);
//         if(numberN % 1 == 0)
//             // тут код вывода 


// }

// }

// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// Methode 1


string Spreadsheet(int nNum)
{
    string spreadsheetResult = "____________\n"; // Возврат каретки
    for (int i = 1; i <= nNum; i++)
    {
        spreadsheetResult = spreadsheetResult + $"|{i,5}|{i * i,5}| \n";
    }
    spreadsheetResult = spreadsheetResult+ "-------------";
    return spreadsheetResult;
}

Console.Write("Введи  число N:");
int n = Convert.ToInt32(Console.ReadLine());

string result = Spreadsheet(n);
Console.Write(result);

// // Methode 2

// int GetUserData()
// {
//     int newNumber = Convert.ToInt32(Console.ReadLine());

//     while (newNumber <= 0)
//     {
//         Console.WriteLine("Введите число больше 0");
//         newNumber = Convert.ToInt32(Console.ReadLine());
//     }
//     return newNumber;
// }

// void Square(int userNumber)
// {
//     for (int i = 1; i <= userNumber; i++)
//     {
//         Console.WriteLine($"|{i,3} | {i * i,3}|");
//     }
// }

// Square(GetUserData());


// sqrt((x2-x1)^2+(y2-y1)^2+(z2-z1)^2)
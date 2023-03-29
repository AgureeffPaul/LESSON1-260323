// Вводим число N выводим все целые числа от -N до N


Console.WriteLine("Введите положительное целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int count = -number;

while (count <= number)
{
    Console.Write ($"{count}, ");
    count ++;
}
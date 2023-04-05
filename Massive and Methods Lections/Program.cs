// Поиск максимума из 9 элементов

//               0  1  2  3 4  5  6  7  8
// int [] array = {11,211,31,41,15,61,17,18,19};
// array[0] = 12;
// // Console.WriteLine(array[7]);

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );

// int Max(int arg1, int arg2, int arg3)
// {
// int result = arg1;
// if (arg2 > result) result = arg2;
// if (arg3 > result) result = arg3;
// return result;
// }

// Console.WriteLine(result);

// to be continued ...

// // *** Поиск элемента в массиве FIND

// int [] array = {1,211,311,414,155,617,414,184,199};

// int n = array.Length;
// int find = 414;
// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

// // *** Заполнение массива случайными числами и вывод на экран массива

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOff (int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;       

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOff(array, 4);   
Console.WriteLine(pos);






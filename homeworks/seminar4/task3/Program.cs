// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void newArray (int size, int min, int max) 
{
    int [] newArray= new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min,max+1);
    }
    var str = string.Join(" ", newArray);

    Console.WriteLine(str);
}

Console.Write("Введите размер >>> ");
int userSize = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите мин >>> ");
int min= Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите макс >>> ");
int max= Convert.ToInt32(Console.ReadLine()); 
newArray(userSize,min,max);



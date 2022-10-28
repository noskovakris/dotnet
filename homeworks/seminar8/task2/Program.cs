// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int [,] createArray (int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < columns; j++)
            newArray[i,j] = new Random().Next(1,10);

    }
    return newArray;
        
}

void showArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void countRows(int[,] array)
{   
    int minSumRow=0;
    int[]sumOfRows = new int[array.GetLength(0)];
    for(int i=0; i < array.GetLength(0); i++)
    {
        int sumRow=0;
        for(int j=0; j < array.GetLength(1); j++)
            {
                sumRow+= array[i,j];
            }
        sumOfRows[i]=sumRow;
    }
    int minValue = sumOfRows.Min();
    int indexMin = Array.IndexOf(sumOfRows, minValue);
    Console.WriteLine($"{indexMin+1} строка");
}  


Console.Write("Введите количество строк  >>> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов >>> ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray  = createArray(m,n);
showArray (myArray);


countRows (myArray);


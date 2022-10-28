// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}


void averageRow(int [,] array)
{   
 string result = "Среднее строк  >>> ";
    for (int i=0; i<(array.GetLength(0)); i++) 
    {
        int sumRow = 0;
        for (int j=0; j<(array.GetLength(1)); j++) sumRow +=array[i,j];
        sumRow=sumRow/array.GetLength(1);
        result+=sumRow+" ";
        
    }
Console.Write(result);

}

Console.Write("Введите количество строк  >>> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов >>> ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray  = createArray(m,n);
showArray (myArray);
//Console.WriteLine(myArray.GetLength(0));
averageRow(myArray);
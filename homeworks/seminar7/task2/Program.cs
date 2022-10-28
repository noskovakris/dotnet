// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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


void checkArrayPosition(int i, int j, int [,] array)
{   

    if (array.GetLength(0)>=i) 
    {
        if (array.GetLength(1)>=j) 
             Console.Write(array[i,j]);
    }
      
    else Console.Write("такого числа в массиве нет");

}

Console.Write("Введите количество строк  >>> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов >>> ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray  = createArray(m,n);
showArray (myArray);


Console.Write("Введите номер строки  >>> ");
int j = Convert.ToInt32(Console.ReadLine())-1;

Console.Write("Введите номер столбца  >>> ");
int k = Convert.ToInt32(Console.ReadLine())-1;



checkArrayPosition (j,k,myArray);


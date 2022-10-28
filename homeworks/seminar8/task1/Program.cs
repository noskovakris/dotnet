// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
    }
    Console.WriteLine();
}

void orderMaxMin(int[,] array)
{   
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            int minPosition = j;
            for(int k=j+1; k < array.GetLength(1); k++)
            {
                if(array[i,k] < array[i,minPosition])
                {
                    minPosition = k;
                }
                int temporary = array[i,j];
                array[i,j] = array[i,minPosition];
                array[i,minPosition] = temporary;
            }
        }
        
    }
     Console.WriteLine();
}


Console.Write("Введите количество строк  >>> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов >>> ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray  = createArray(m,n);
showArray (myArray);


orderMaxMin (myArray);
showArray (myArray);

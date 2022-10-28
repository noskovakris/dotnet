// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int [,] calculate(int[,] array1, int[,] array2)
{   
    int[,] product = new int[array1.GetLength(0),array2.GetLength(1)];

    int matrix1Rows=array1.GetLength(0);
    int matrix1Cols=array1.GetLength(1);

    int matrix2Rows=array2.GetLength(0);
    int matrix2Cols=array2.GetLength(1);

  
    // цикл по каждому ряду первой матрицы
    for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++) 
    {  
        // цикл по каждому столбцу второй матрицы  
        for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++) 
        {  
            // вычисляем скалярное произведение двух векторов  
            for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++) 
            {  
                product[matrix1_row, matrix2_col] +=   
                array1[matrix1_row, matrix1_col] *   
                array2[matrix1_col, matrix2_col];  
            }  
        }  
    }  
  
   return product;  
}
    


// Console.Write("Введите количество строк  >>> ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов >>> ");
// int n = Convert.ToInt32(Console.ReadLine());

//int [,] myArray  = createArray(m,n);
//showArray (myArray);

int[,] array1 = new [,] { { 2, 4 }, { 3, 2 }};
int[,] array2 = new [,] { { 3, 4 }, { 3, 3 }};

calculate (array1,array2);

showArray (calculate (array1,array2));

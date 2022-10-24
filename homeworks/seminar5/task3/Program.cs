// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] createRandomArray (int size, double minValue, double maxValue)
{
    double [] newArray = new double [size];
    for (int i=0; i< size; i++)
    {
        newArray[i] = new Random().NextDouble ();
    }
    return newArray;
}

void showArray (double [] array)
{
    Console.Write ($"Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
    Console.WriteLine();
}

void countArray (double [] array)
{
    double maxInArray = array[0];
    double minInArray = array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]>maxInArray)
        maxInArray =array[i]; 
        else
        {
            if (array[i]<minInArray)
            minInArray =array[i]; 
        }
        
    }
    Console.WriteLine($"Разница >>> {maxInArray-minInArray }");

}

double [] myArray = createRandomArray(4,10.0,99.9);

showArray(myArray);

countArray (myArray);
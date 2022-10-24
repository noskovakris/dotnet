// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] createRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i=0; i< size; i++)
    {
        newArray[i] = new Random().Next (minValue,maxValue+1);
    }
    return newArray;
}

void showArray (int [] array)
{
    Console.Write ($"Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
    Console.WriteLine();
}

void countArray (int [] array)
{
    int maxInArray = array[0];
    int minInArray = array[0];
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

int [] myArray = createRandomArray(4,10,99);

showArray(myArray);

countArray (myArray);

// Console.Write("Введите размер >>> ");
// int userSize = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите мин трехзначное>>> ");
// int min= Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите макс >>> ");
// int max= Convert.ToInt32(Console.ReadLine()); 
// newArray(userSize,min,max);
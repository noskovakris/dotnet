// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] createRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i=0; i< size; i++)
    {
        newArray[i] = new Random().Next (minValue,maxValue + 1);
    }
    return newArray;
}

void showArray (int[] array)
{
    Console.Write ($"Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
    Console.WriteLine();
}

void countArray (int[] array)
{
    int evenCount = 0;
    int oddCount = 0;
    for (int i=0; i < array.Length; i++)
    {
        if ((array[i]%2)==0)
        evenCount +=1; 
        else
        oddCount +=1;
    }
    Console.WriteLine($"Четных >>> {evenCount}");
    Console.WriteLine($"НеЧетных >>> {oddCount}");
}

int [] myArray = createRandomArray(4,100,999);

showArray(myArray);

countArray (myArray);

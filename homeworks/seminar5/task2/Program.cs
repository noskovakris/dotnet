// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

void summOddElements (int[] array)
{
    int oddCount = 0;
    for (int i=1; i < array.Length; i++)
    {
        if ((i%2)!=0)
        oddCount +=array[i]; 
 
    }
    Console.WriteLine($"Сумма элементов НеЧетных позиций>>> {oddCount}");
}

int [] myArray = createRandomArray(4,10,99);

showArray(myArray);

summOddElements (myArray);


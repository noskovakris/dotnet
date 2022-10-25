// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void userDigits (int size)
{
    int [] userDigits= new int [size];
    Console.WriteLine("Введите числа: ");
    for(int i=0; i < size; i++)
    {
        Console.Write($"Введите число {i+1}>>> ");
        userDigits[i] = Convert.ToInt32(Console.ReadLine());
    }
    greaterZero (userDigits);
}

void greaterZero (int [] userDigits)
{
    int greaterZeroResult = 0;
    for(int i=0; i < userDigits.Length; i++)
    {
        
        if ((userDigits[i])>0)
        {
            greaterZeroResult +=1; 
        }
    }
    Console.WriteLine($"Больше нуля> >>> {greaterZeroResult}");
}


Console.Write("Введите число элементов массива  >>> ");
int size = Convert.ToInt16(Console.ReadLine());
userDigits (size);
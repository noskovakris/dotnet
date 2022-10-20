// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




void userNubemberPower (int number) 
{
    int result = 1;
    for (int i = 0; i < number; i++)
    {
        Console.Write(Math.Pow(result,3) + " ");
        result++;

    }

}

Console.Write("Введите число >>> ");
int task = Convert.ToInt32(Console.ReadLine()); 
userNubemberPower(task);

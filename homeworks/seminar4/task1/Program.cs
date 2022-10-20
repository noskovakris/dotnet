// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



void intoPower (double baseInt, double powerInt) 
{
    double result = Math.Pow(baseInt,powerInt);
    Console.WriteLine(result);
}

Console.Write("Введите число >>> ");
double baseInt = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите степень >>> ");
double powerInt = Convert.ToDouble(Console.ReadLine()); 
intoPower(baseInt,powerInt);
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void userDifindCoordinates (decimal k1, decimal k2, decimal b1, decimal b2)
{
    decimal fingX = 0;
    decimal fingY = 0;
    fingX =  Math.Round((b2 - b1)/(k1 - k2),1);
    fingY =  Math.Round((k1 * fingX + b1),1);

    Console.WriteLine($"({fingX} ; {fingY})");
}


Console.Write("Введите b1  >>> ");
decimal b1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Введите k1  >>> ");
decimal k1 = Convert.ToDecimal(Console.ReadLine());


Console.Write("Введите b2  >>> ");
decimal b2 = Convert.ToDecimal(Console.ReadLine());


Console.Write("Введите k2  >>> ");
decimal k2 = Convert.ToDecimal(Console.ReadLine());
userDifindCoordinates (k1,k2,b1,b2);
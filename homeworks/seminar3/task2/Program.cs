// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




void distance (double xa, double ya, double za, double xb, double yb, double zb) 
{
    double result = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));
    Console.Write(result);
}

Console.Write("Введите для 1 числа X >>> ");
double x1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите для 1 числа Y >>> ");
double y1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите для 1 числа Z >>> ");
double z1 = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Введите для 2 числа X >>> ");
double x2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите для 2 числа Y >>> ");
double y2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите для 2 числа Z >>> ");
double z2 = Convert.ToDouble(Console.ReadLine()); 

distance(x1,y1,z1,x2,y2,z2);


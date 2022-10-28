// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int findSum (int m, int n)
{   
    if (m<=n)return m +  findSum(m+1,n);
    else return 0;
}


Console.Write("Введите M  >>> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N  >>> ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(findSum (m, n));
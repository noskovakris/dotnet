// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

void sumDigit (string task) 
{
    int length = task.Length;
    double sum = 0;
    
    for (int i = 0; i < length; i++)
    {
        double add = char.GetNumericValue(task[i]);
        sum=sum+add;
    }
    
    Console.WriteLine(sum);
}

Console.Write("Введите число >>> ");
string task = Console.ReadLine(); 
sumDigit(task);


// string l = "452";
// Console.WriteLine(l[1]);
// int lng = Convert.ToInt32(l);
// Console.WriteLine(lng);

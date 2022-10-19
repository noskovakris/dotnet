/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.Write("Введите день >>> ");
string task = (Console.ReadLine()).ToLower(); 
string [] weekEnd = {"суббота", "воскресенье"};

void isWeekend (string a) {
    if (weekEnd.Contains(a))
        {Console.WriteLine("да");
        }
    else
        {Console.WriteLine("нет");
        }
}

isWeekend(task);
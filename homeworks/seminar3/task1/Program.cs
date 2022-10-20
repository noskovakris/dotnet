// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Задача 21



void palindrom (string text) 
{
    string result = String.Empty;
    int length = text.Length;
    if (text[0]==text[length-1])
         {
             if (text[1]==text[length-2])
            {
                Console.WriteLine("да");
            }
        }
    else
        {
            Console.WriteLine("нет");
        }
}

Console.Write("Введите число >>> ");
string task = Console.ReadLine(); 
int length = task.Length;
palindrom(task);




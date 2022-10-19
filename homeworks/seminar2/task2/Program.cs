// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6


Console.Write("Введите число >>> ");
string task = Console.ReadLine(); 

void thirddDigit (string a) {
    char[] arr = task.ToCharArray(0, task.Length);
    if (task.Length>2)
        {char result = arr[2];
        Console.WriteLine(result);
        }
    else
        {Console.WriteLine("третьей цифры нет");
        }
}

thirddDigit(task);

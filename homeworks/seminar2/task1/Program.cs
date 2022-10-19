//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введите число >>> ");
string task = Console.ReadLine(); 

char secondDigit (string a) {
    char[] arr = task.ToCharArray(0, task.Length);
        char result = arr[1];
        return result;
}

Console.WriteLine(secondDigit(task));
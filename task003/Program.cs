﻿//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

int a = 0;
System.Console.Write("Введите номер от 1 до 7: ");
a = int.Parse(Console.ReadLine());
if (a > 0 && a < 8)
{
    if (a == 1)
    {
        System.Console.WriteLine("Понедельник");
    }
    else if (a == 2)
    {
        System.Console.WriteLine("Вторник");
    }
    else if (a == 3)
    {
        System.Console.WriteLine("Среда");
    }
    else if (a == 4)
    {
        System.Console.WriteLine("Четверг");
    }
    else if (a == 5)
    {
        System.Console.WriteLine("Пятница");
    }
    else if (a == 6)
    {
        System.Console.WriteLine("Суббота");
    }
    else if (a == 7)
    {
        System.Console.WriteLine("Воскресенье");
    }
    }
else 
{
    System.Console.WriteLine("неверные данные");
}

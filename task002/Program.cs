//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет


int a = 0;
int b = 0;
Console.WriteLine("Введите первое число");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да");
}
else 
{
    System.Console.WriteLine("Нет");
}

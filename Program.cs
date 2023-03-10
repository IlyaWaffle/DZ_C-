#pragma warning disable
/*       **Задача 16:**
Напишите программу, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго.    */

int num;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out num);
if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");


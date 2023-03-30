/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 || number < 1000)
{
int result = ((number % 100 - number % 10) / 10);
Console.WriteLine(result);
}
else
Console.WriteLine("Это не трехзначное число: ");



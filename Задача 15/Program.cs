/*Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.WriteLine ("Введите цифру: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7) 
Console.WriteLine ("Это выходной день");
    else 
    if (number <= 5) 
    Console.WriteLine ("Это будний день");
    else 
    if (number > 7)
    Console.WriteLine ("В неделе всего 7 дней!");

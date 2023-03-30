/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Clear();
int number =  int.Parse(Console.ReadLine());
int result = (number % 10);
Console.WriteLine("Третья цифра: ");
if (number < 100){
   Console.WriteLine("Третьей цифры нет"); 
}

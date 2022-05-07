/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Вариант1:

using System;
Console.Clear();
Console.WriteLine("Input num");
string num = Console.ReadLine();
Console.WriteLine(num.Substring(1, 1));

Вариант2:

using System;
Console.Clear();
Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());
int x = num/10 % 10;
Console.WriteLine(x);

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;
Console.Clear();
Console.WriteLine("Input num");
string num = Console.ReadLine();
int lenght = num.Length;
if (lenght>2)
{
  Console.WriteLine(num.Substring(2, 1));  
}
Console.WriteLine("третьей цфры нет");



/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


using System;
Console.Clear();
Console.WriteLine("Input weekday number");
int num = Convert.ToInt32(Console.ReadLine());
if (num>7)
{
    Console.WriteLine("Input numbers from 1 to 7");
}
if (num <8&&num>5)
{
    Console.WriteLine("It's Weekend!");
}
if (num>1&&num<6)
{
    Console.WriteLine("Weekday");
}

*/



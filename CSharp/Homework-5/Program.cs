/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

using System;
Console.Clear();
Console.WriteLine("enter array size");
int n = 0;
int size = Convert.ToInt32(Console.ReadLine());
int [] array = GetArray(size);
Console.WriteLine(String.Join("_", array));
Console.WriteLine($"кол-во четных чисел: {n}");

int[]GetArray(int size)
{
    int[] fillarray = new int [size];
        for(int i = 0; i<size; i++)
    {
       fillarray [i] = new Random().Next(100,1000);
        if(fillarray[i]%2 == 0)
        {
            n=n+1;
        }
    }
    return fillarray;
}


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/ 
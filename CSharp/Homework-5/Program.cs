/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

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


Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

using System;
Console.Clear();
Console.WriteLine("enter array size");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = GetArray(size);
Console.WriteLine(String.Join(" ", array));
int sum = 0;                                 //почему нельзя написать в одну строку: = 0 + Getsum ?
sum = 0 + Getsum(size);
Console.WriteLine($"Cумма нечетных элементов: {sum}");

int Getsum(int size)
{
    for(int n = 0; n < size; n= n+2)
    {
        sum = sum+ array[n];
    }
    return sum;
}

int [] GetArray(int size)
{
    int [] fillarray = new int [size];
    for(int i = 0; i<size; i++)
    {
        fillarray[i]= new Random().Next(-1000,1000);
    }
    return fillarray;
}
*/
/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
using System;
Console.Clear();
Console.WriteLine("enter array size");
int size = Convert.ToInt32(Console.ReadLine());
double []array = GetArray(size);
Console.WriteLine(String.Join(" ",array));
double max = array[0]; max = FindMax(size);  //почему-то не хочет присваивать FindMax
double min = array[0]; min = FindMin(size);

Console.WriteLine($"Дельта:{max-min}");

double FindMax(int size)
{
    for(int n=0; n<size-1; n=n+1)
    {
        double max = (array[n]>array[n+1])?array[n]:array[n+1];
    }
    return max;
}

double FindMin(int size)
{
    for(int n=0; n<size-1; n=n+1)
    {
        double min = (array[n]<array[n+1])?array[n]:array[n+1];
    }
    return min;
}

double [] GetArray(int size)   //почему где-то нужно указывать идентийикатор для size, а где-то нет, как в стр. 72 или 77?
{
    double []fillarray= new double [size];
    for(int i = 0; i<size; i++)
    {
        fillarray[i] = new Random().NextDouble();
    }
    return fillarray;
}

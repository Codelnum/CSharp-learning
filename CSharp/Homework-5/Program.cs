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
int sum = Getsum(array);
Console.WriteLine($"Cумма нечетных элементов: {sum}");

int Getsum(int [] array)
{
    for(int n = 0; n < array.Length; n= n+2)
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
Console.WriteLine(String.Join(" ",array)); //ЗАДАН МАССИВ 

double max = FindMax(size);
double min = FindMin(size);

Console.WriteLine($"MAX:{max}");    
Console.WriteLine($"MIN:{min}");
Console.WriteLine($"Дельта:{max-min}");  // Разница между макс и мин

double [] GetArray(int size)  
{
    double []fillarray = new double [size];
    for(int i = 0; i<size; i++)
    {
        fillarray[i] = new Random().NextDouble();
    }
    return fillarray;
}


double FindMax(double max)            
{   max=array[0];
    for(int n=0; n<size-1; n++)
    {
        max = (max<array[n])?array[n]:max; 
    }
    return max;
}

double FindMin(double min)              
{   min=array[0];
    for(int n=0; n<size-1; n++)
    {
        min = (min>array[n])?array[n]:min; 
    }
    return min;
}

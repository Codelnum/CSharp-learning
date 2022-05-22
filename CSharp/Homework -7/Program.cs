
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

using System;
Console.Clear();
Console.WriteLine("enter row size");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("enter column size");
int column = int.Parse(Console.ReadLine());
double[ , ] array = GetArray(row,column);
PrintArray(array);


double [,] GetArray(int row, int column)
{
    double[ , ] result = new double [row,column];
     
    for(int i = 0; i<row ; i++)
    {
        for(int j=0; j<column; j++)
        {
        result[i,j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[ , ] array)
{
for(int i =0; i<row; i++)
{
    for(int j=0; j<column; j++)
    {
        Console.Write ($"{array[i,j]}   ");
    }
    Console.WriteLine();
}
}



Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

using System;
Console.Clear();
Console.WriteLine("enter row size");
int row = int.Parse(Console.ReadLine());  //5
Console.WriteLine("enter column size");
int column = int.Parse(Console.ReadLine());     //6
int [,] array = GetArray(row,column);
PrintArray(array);

Console.WriteLine("enter array index");
int index = int.Parse(Console.ReadLine()); 
int m = index/10;
int n = index%10;
if (m>row-1 || n>column-1)
{
Console.WriteLine("Искомый элемент за пределами массива");
}
Console.WriteLine($"Значение элемента массива с индексом {m} - {n}: {array[m,n]}");


int [,] GetArray(int row, int column)
{
    int[ , ] result = new int [row,column];
     
    for(int i = 0; i<row ; i++)
    {
        for(int j=0; j<column; j++)
        {
        result[i,j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[ , ] array)
{
for(int i =0; i<row; i++)
{
    for(int j=0; j<column; j++)
    {
        Console.Write ($"{array[i,j]}   ");
    }
    Console.WriteLine();
}
}



/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

 using System;
 Console.Clear();
 Console.WriteLine("Random array:");
 int row = new Random().Next(1,10);
 int column = new Random().Next(1,10);
int [,]array = GetArray(row,column);
PrintArray(array);

    for (int j = 0; j < column; j++)
    {   double sum = 0;
    
        for (int i = 0; i <row; i++)
        {
            sum = sum + array[i,j];
            
        }
        Console.WriteLine($"Сумма чисел в столбце:{sum}");
        double average = Math.Round(sum/row, 2);
        Console.WriteLine($"Среднее столбца:{average}");
         
    }



void PrintArray(int[,]array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int[,]GetArray(int row, int column)
{
    int [,]result = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i,j]= new Random().Next(0,10);
        }
    }
    return result;
}

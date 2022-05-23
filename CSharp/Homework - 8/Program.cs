﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
/*
using System;
Console.Clear();
int row = new Random().Next(1,10);
int column = new Random().Next(1,10);
Console.WriteLine($"Задан произвольный массив [{row},{column}]:");
int [,] array = GetArray (row, column);
PrintArray(row,column);
Console.WriteLine("Упорядочить числа в строках по возрастанию:");
BubbleSortArray(array);
PrintArray(row,column);


void BubbleSortArray(int[,]array)
{ 
for(int k = 0; k< row*column ; k++)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column-1; j++)
        {
            if (array[i,j]> array[i,j+1])
            {
                int temp = array[i,j+1];
                array[i,j+1] = array[i,j];
                array[i,j] = temp;
            }
        }
    }
}
}


void PrintArray(int row, int column)
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


int [,] GetArray (int row, int column)
{
    int [ , ]result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i,j] = new Random().Next(0,10);
        }
    }
    return result;
}
*/


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
using System;
 Console.Clear();
 Console.WriteLine("Random array:");
 int row = new Random().Next(2,5);
 int column = new Random().Next(2,5);
 Console.WriteLine($"Произвольный массив [{row},{column}]:");
int [,]array = GetArray(row,column);
PrintArray(array);
double min = double.PositiveInfinity;
int rowindex = 0;
for (int i = 0; i < row; i++)
{   double sum = 0;
    
        for (int j = 0; j <column; j++)
        {
            sum = sum + array[i,j]; // сумма строки
        }
        
        if(sum<min)
        {
            min=sum;
            rowindex = i;
        }
        
        //Console.WriteLine($"Сумма в строке:{sum}");
        //Console.WriteLine($"Мин. сумма в строках:{min}");
} 
        Console.WriteLine($"Номер строки с минимальной суммой:{rowindex+1}");      


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

*/





/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
using System;
 Console.Clear();
int arrayRowSize = new Random().Next(1,10);
int arrayColumnSize = new Random().Next(1,10);
int row = arrayRowSize; 
int column = arrayColumnSize; 

int [,]array1 = GetArray1(row,column);
int [,]array2 = GetArray2(row,column);
Console.WriteLine($"Массив 1 [{row},{column}]:");
PrintArray1(array1);
Console.WriteLine($"Массив 2 [{row},{column}]:");
PrintArray2(array2);
Console.WriteLine($"Перемноженный массив [{row},{column}]:");
int[,]array = MultiplArray(row,column);

PrintArray(array);



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


int[,]MultiplArray(int row, int column)
{
    int [,]result = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i,j]= array1[i,j]*array2[i,j];
        }
    }
    return result;
}



int[,]GetArray1(int row, int column)
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
int[,]GetArray2(int row, int column)
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
void PrintArray1(int[,]array1)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array1[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray2(int[,]array2)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array2[i,j]} ");
        }
        Console.WriteLine();
    }
}
/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/





/*Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/
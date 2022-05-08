/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

using System;
using System.Linq;
Console.Clear();
Console.WriteLine("Введите числа массива через пробел");
string M = Console.ReadLine();
int size = M.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Length;
Console.WriteLine($"Чисел в массиве: {size}");
int[] array = M.Split(' ').Select(int.Parse).ToArray();
int count = 0;
int num = CountNum(array);
Console.WriteLine($"Чисел больше нуля: {num}");

int CountNum(int[]array)
{ 
        for(int i = 0; i < size; i++)
    {
        if( array[i] > 0)
        {
            count++;
        }
    }
return count;
}
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, 
b2 = 4, k2 = 9   -> (-0,5; 5,5)
*/
using System;
Console.Clear();
Console.WriteLine("Ведите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2-b1)/(k1-k2);  //(4-2)/(5-9) = 2/-4 = -0.5

double y = k1 * x + b1;     //  5*-0.5 + 2 = -2.5+2 = -0.5
  //double y2 = k2 * x + b2;    9*-0.5+4 = -4.5 + 4 = -0.5
Console.WriteLine($"Точка пересечения: ({x};{y})");
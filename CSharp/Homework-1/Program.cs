
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;
Console.Clear();
Console.WriteLine("Write num 1"); 
int a1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Write num 2"); 
int a2 = Convert.ToInt32(Console.ReadLine());
int max = (a1>a2)?a1:a2;
Console.WriteLine($"Max num = {max}");
*/



/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
Console.Clear();
Console.WriteLine("Write num 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write num 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write num 3");
int c = Convert.ToInt32(Console.ReadLine());
int max = (a>b&&a>c)?a:(b>a&&b>c)?b:c;
Console.WriteLine($"Max num = {max}");
*/



/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;
Console.Clear();
Console.WriteLine("Write num");
int a = Convert.ToInt32(Console.ReadLine());
string num = (a%2 == 0)?"четное число.":"не четное число.";
Console.WriteLine(num);
*/



/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
Console.Clear();
Console.WriteLine("Enter num");
int N = Convert.ToInt32(Console.ReadLine());
int b = 0;
Console.WriteLine($"Четные числа от 1 до {N}:");
if (N==1)
 {
     Console.WriteLine("Четных чисел нет");
 }
else
{
    while (b<N-1)
    {
        b=b+2;
        Console.Write($"{b} ");  
    }    
}
*/

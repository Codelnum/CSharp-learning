/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.

M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 5, 4"
*/
/*
using System;
using static System.Console;
Clear();
WriteLine("enter M");
int a = int.Parse(ReadLine());
WriteLine("enter N");
int b = int.Parse(ReadLine());
int M =(a<=b)?a:b;
int N = (a>=b)?a:b;

string result = GetNumbers(N, M);
WriteLine (result);

static string GetNumbers(int start, int end)
{
if(start==end) return start.ToString();
return(start+", "+GetNumbers(start-1,end));
}
*/


/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*

using System;
using static System.Console;
Clear();
WriteLine("enter M");
int a = int.Parse(ReadLine());
WriteLine("enter N");
int b = int.Parse(ReadLine());

int M =(a<b)?a:b;
int N = (a>b)?a:b;
if (a==b)
{
    M= N = 0;
}
int sum = GetSum(M,N);
WriteLine(sum);


int GetSum(int start, int end)
{
    int summ = 0;
    if(start>end) return summ;
    return(summ=summ+start+GetSum(start+1,end));
}

*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29

A(m,n) =  
n+1                при        m=0
A(m-1, 1)          при        m>0 и n=0
A(m-1, A(m, n-1))  при        m>0 и n>0
*/
using System;
using static System.Console;
Clear();
WriteLine("enter M");  //Stack overflow при M>=4 && N>=1
int M = int.Parse(ReadLine());
WriteLine("enter N");
int N = int.Parse(ReadLine());
int akk = Akkerman(M,N);
if (akk==0)
{
   WriteLine("Неверные входные данные");
}
else
{
WriteLine(akk);
}
int Akkerman(int M, int N)
{
    if(M==0 && N>=0)
        {
             return (N+1);
        }
    if(M>0 && N==0)
        {
           return Akkerman(M-1, 1); 
        }
    if(M>0 && N>0)
        {
           return Akkerman(M-1, Akkerman(M, N-1)); 
        }
        return 0;
}



﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число a: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Введите число b: "); 
int b = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число c: "); 
int c = Convert.ToInt32(Console.ReadLine()); 

int max = a;

if(a>max) max = a;
if(b>max) max = b;
if(c>max) max = c;

System.Console.Write("max=");
System.Console.WriteLine(max);  

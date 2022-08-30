// See Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

System.Console.Write("Введите число: "); 
 
int n = Convert.ToInt32(Console.ReadLine()); 
 
 
int lastDigit = n % 10; 
 
System.Console.WriteLine(lastDigit);
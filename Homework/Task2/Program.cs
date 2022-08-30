// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число a: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Введите число b: "); 
int b = Convert.ToInt32(Console.ReadLine()); 

int max = a;
int min = b;

if(a>b) max = a;
if(b>a) max = b;
if(a<b) min = a;
if(b<a) min = b;

System.Console.Write("max=");
System.Console.WriteLine(max); 
System.Console.Write("min=");
System.Console.WriteLine(min); 
// Задача 4: Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a, b, c, max;
a = 2;
Console.WriteLine(a);
b = 3;
Console.WriteLine(b);
c = 7;
Console.WriteLine(c);
max = a;

if(b > max)
{
  max = b;
}
if(c > max)
{
  max = c;
}
Console.WriteLine("max = " + max);

a = 44;
Console.WriteLine(a);
b = 5;
Console.WriteLine(b);
c = 78;
Console.WriteLine(c);
max = a;

if(b > max)
{
  max = b;
}
if(c > max)
{
  max = c;
}
Console.WriteLine("max = " + max);

a = 22;
Console.WriteLine(a);
b = 3;
Console.WriteLine(b);
c = 9;
Console.WriteLine(c);
max = a;

if(b > max)
{
  max = b;
}
if(c > max)
{
  max = c;
}
Console.WriteLine("max = " + max);
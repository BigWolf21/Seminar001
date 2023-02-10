// Задача 2: Напишите программу,
// которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a, b;

a = 5;
Console.WriteLine(a);
b = 7;
Console.WriteLine(b);
if (a > b)
{
  Console.WriteLine("max = " + a);
}
  else
  {
    Console.WriteLine("max = " + b);
  }

a = 2;
Console.WriteLine(a);
b = 10;
Console.WriteLine(b);
if (a > b)
{
  Console.WriteLine("max = " + a);
}
  else
  {
    Console.WriteLine("max = " + b);
  }

a = -9;
Console.WriteLine(a);
b = -3;
Console.WriteLine(b);
if (a > b)
{
  Console.WriteLine("max = " + a);
}
  else
  {
    Console.WriteLine("max = " + b);
  }
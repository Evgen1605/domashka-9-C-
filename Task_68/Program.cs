// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine()!);
Write("Введите N: ");
int n = int.Parse(ReadLine()!);

WriteLine($"M = {m}, N = {n} -> A({m}, {n}) = {FunctionAckerman(m, n)}");

int FunctionAckerman(int start, int end)
{
  if (start == 0) return end + 1;
  if (start > 0 && end == 0) 
  {return FunctionAckerman(start -1, 1);}
  if (start > 0 && end > 0)
  {return FunctionAckerman(start -1,FunctionAckerman(start, end -1));}

  return FunctionAckerman(start, end);
}
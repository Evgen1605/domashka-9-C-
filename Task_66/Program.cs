// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine()!);
Write("Введите N: ");
int n = int.Parse(ReadLine()!);


WriteLine($"M = {m}; N = {n} -> {PrintNumbers(m, n)}");

int PrintNumbers(int start, int end)// функция складывает числа от начальгого до конечного
{
  if (start == end)// проверяем пока начальное значение не приравняется к конечному
  {
    return start;
  }

  int s = end + PrintNumbers(start, end - 1);// складываем числа
  return (s);
}
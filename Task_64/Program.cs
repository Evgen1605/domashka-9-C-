// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine()!);

// for (int i = 1; i <= n; i++)
// {
//   Write($"{i} ");
// }
// WriteLine();

WriteLine(PrintNumbers(n));

string PrintNumbers(int end)// функция выдаёт натуральные числа в промежутке от 1 до заданное пользователем(n) например 4
{
  if (end == 1)// проверяет пока конечное число (заданное пользователем) не приравняется 1
  {
    WriteLine(end);
    return end.ToString();// возвращает строку начиная с 1
  }
  string s = end.ToString() + " " + PrintNumbers(end - 1);
  WriteLine(s);// выводит в консоль
  return s;// возвращает строку s 
}
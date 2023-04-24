/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

using System;
using static System.Console;

// получаем данные от пользователя и переводим в Int
int Getnumber(string prompt)
{
    Write($"{prompt}: ");

    int result=int.Parse(ReadLine());

    return result;
}

string NumsRange(int numFirst, int numSecond)
{
    if (numFirst==numSecond)
    {
        return numSecond.ToString();
    }
    return numSecond + ", " + NumsRange(numFirst,--numSecond);

}

Clear();
int firstNumber = Getnumber("Введите минимальное число диапазона");

int lastNumber = Getnumber("Введите максимальное число диапазона");

Write(NumsRange(firstNumber,lastNumber));

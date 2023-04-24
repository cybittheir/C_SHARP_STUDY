/*

Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

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

// считаем сумму диапазона чисел
int SummRange(int numFirst, int numSecond)
{
    
    if (numFirst<numSecond)
    {
        return numFirst + SummRange(++numFirst,numSecond);
    }

    return numFirst;  
}

// тело программы
Clear();

int firstNumber = Getnumber("Введите минимальное число диапазона");
int lastNumber = Getnumber("Введите максимальное число диапазона");

Write(SummRange(firstNumber,lastNumber));

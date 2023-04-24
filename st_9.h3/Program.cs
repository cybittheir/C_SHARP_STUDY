/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

using System;
using static System.Console;

// получаем данные от пользователя и переводим в Int
int Getnumber(string prompt)
{
    Write($"{prompt}: ");

//    uint result=int.Parse(ReadLine());
    int result=Convert.ToInt32(ReadLine());

    return result;
}

// считаем функцию Аккермана
int Akkerman(int m, int n)
{
    
    if (m == 0)
    {
        return n + 1;

    } else if (n == 0 && m > 0)
    {
        return Akkerman(m-1,1);
    
    } else if (n > 0 && m > 0)
    {
    
        return Akkerman(m-1,Akkerman(m,n-1));
    
    } else {
    
        return 0;
    
    }

}

// тело программы
Clear();

int firstNumber = Getnumber("Введите первый аргумент (m)");
int lastNumber = Getnumber("Введите второй аргумент (n)");

Write(Akkerman(firstNumber,lastNumber));

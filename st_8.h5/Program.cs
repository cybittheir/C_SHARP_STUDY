/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;
using static System.Console;

void PrintResult(int[,]table)
{
    for (int i1=0;i1<table.GetLength(0);i1++)
    {
        Write("[ ");
        for (int j1=0;j1<table.GetLength(1);j1++)
        {
            string dNull=table[i1,j1]<10?"0":""; // добавляем 0 перед числом до 10. Пока полагаем, что размер матрицы будет меньше 10
            Write ($"{dNull}{table[i1,j1]} ");
        }
        WriteLine(" ]");
    }

}

// заполнение матрицы по спирали
int[,] FillSpiral(int size){

    int [,] table = new int[size,size];
    int num = 1; // первая цифра для заполнения
    int range = size*size; // последняя цифра для заполнения
    int round=0; // условный номер круга спирали

    while (num<range + 1){
        // горизонталь вправо
        for (int r=round;r<size;r++)
        {
            table[round,r] = num;
            num++;
        }

        // вертикаль вниз
        for (int i=round+1;i<size;i++)
        {
            table[i,size-1] = num;
            num++;
        }

        // горизонталь влево
        for (int i=size-2;i>=round;i--)
        {
            table[size-1,i] = num;
            num++;
        }

        // вертикаль вверх
        for (int i=size-2;i>round;i--)
        {
            table[i,round] = num;
            num++;
        }    
        
        round++;
        size--; // уменьшаем условный диаметр круга

    }

    return table;

}

// получаем данные от пользователя и переводим в Int
int GetSize(string prompt)
{
    Write($"{prompt}: ");

    int result=int.Parse(ReadLine());

    return result;
}

// тело программы

Clear();
int[,]table = FillSpiral(GetSize("Введите размер стороны матрицы"));
PrintResult(table);

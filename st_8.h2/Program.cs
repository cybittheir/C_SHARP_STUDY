/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;
using static System.Console;

// принимаем пару входных данных и возвращаем в массиве
int [] GetCommaInput(string prompt)
{
    int [] result = new int[2];
    Write(prompt);

    string [] invalues=ReadLine().Split(",");

    result[0]=Convert.ToInt32(invalues[0]);
    result[1]=Convert.ToInt32(invalues[1]);

    return result;
}


// генерация массива целых чисел с задаваемыми размером и крайними значениями
int [,] CreateIntArray(int lines,int columns,int min,int max){

    int [,] result=new int[lines,columns];
    for (int i=0;i<lines;i++)
    {
        Random dRandom = new Random();

        for (int j=0;j<columns;j++)
        {
            result[i,j] = dRandom.Next(min,max-1);
        }
    }
    return result;
}

// вывод на экран массива чисел
void PrintIntArray(int [,]array)
{
    for (int i=0;i < array.GetLength(0);i++)
    {
        Write("[ ");

        for (int j=0;j<array.GetLength(1);j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine("]");
    }
}

// вычисление суммы элементов строки массива
int LineSumm(int [,] array,int line)
{
    int result=0;

    for(int i=0;i<array.GetLength(1);i++)
    {
        result+=array[line,i];
    }

    return result;

}

Clear();

int[] size=GetCommaInput("введите через запятую размеры массива(строки,колонки): ");
int[] nums=GetCommaInput("введите через запятую крайние значения элементов массива(min,max): ");
int[,]tmpArray=CreateIntArray(size[0],size[1],nums[0],nums[1]);

int minSumm=LineSumm(tmpArray,0);
int minNum=0;

for (int i=1;i<tmpArray.GetLength(0);i++)
{
    if (LineSumm(tmpArray,i)<minSumm)
    {
        minSumm=LineSumm(tmpArray,i);
        minNum=i;
    }

}

WriteLine("\n==== sourсe ====");
PrintIntArray(tmpArray);

WriteLine($"\nминимальная сумма элементов в {minNum+1} строке ({minSumm})");


/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

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

// свой вариант NextDouble с параметром разрядности. по-умолчанию 0.0

double DoubleRandom(int bit=1)
{
    Random dRandom = new Random();
    int div=Convert.ToInt32(Math.Pow(10, bit));
    double number = dRandom.Next(0,div);
    return number/div;

}

// генерация массива двоичных чисел с задаваемыми размером, максимуми и разрядностью
double [,] CreateDoubleArray(int lines,int columns,int min,int max, int bit=1){

    double [,] result=new double[lines,columns];
    for (int i=0;i<lines;i++)
    {
        Random dRandom = new Random();

        for (int j=0;j<columns;j++)
        {
            result[i,j] = dRandom.Next(min,max-1) + DoubleRandom(bit);
        }
    }
    return result;
}

// вывод на экран массива двоичных чисел
void PrintDoubleArray(double [,]array)
{
    for (int i=0;i < array.GetLength(0);i++)
    {
        Write("[ ");

        for (int j=0;j<array.GetLength(1);j++)
        {
            Write($"{array[i,j]:f1} ");
        }
        WriteLine("]");
    }
}

// основная часть программы 
int []tableSize=GetCommaInput("Введите через запятую количество строк и колонок таболицы: ");
int []minmax=GetCommaInput("Введите через запятую минимальные и максимальные значения ячеек: ");

//  битность ну указываем, используем значение по-умолчанию
double [,] newDouble = CreateDoubleArray(tableSize[0],tableSize[1],minmax[0],minmax[1]);
PrintDoubleArray(newDouble);

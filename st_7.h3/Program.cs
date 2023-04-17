/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


using System;
using static System.Console;

//принимаем входные данные через запятую. результат массив длинной 2, int
int [] GetCommaInput(string prompt)
{
    int [] result = new int[2];
    Write(prompt);

    string [] invalues=ReadLine().Split(",");

    result[0]=Convert.ToInt32(invalues[0]);
    result[1]=Convert.ToInt32(invalues[1]);
    return result;
}

// Генерация целочисленого массива

int [,] CreateIntTable(int lines,int columns,int min,int max){

    Random newRandom = new Random();

    int [,] result=new int[lines,columns];

    for (int i=0;i<lines;i++)
    {

        for (int j=0;j<columns;j++)
        {
            result[i,j] =newRandom.Next(min,max+1);
        }

    }
    return result;
}

// вывод на экран целочисленного массива
void PrintIntTable(int [,]array)
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

// вычисление ср. арифметического главной диагонали, вывод на экран результатов
void GetAvgDiag(int[,] array){
    
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int summ = 0;
    int numbers = 0;

    int min = x < y ? x : y;

    for (int i=0;i<min;i++)
    {
        summ+=array[i,i];
        numbers=i+1;
    }

    double avgSum = Convert.ToDouble(summ)/numbers;

    WriteLine($"\nСреднее арифметическое по главной диагонали {summ} / {numbers} = {avgSum:f2};");
    
    WriteLine("\nДля контроля: ");
    PrintIntTable(array);

}

// вычисление ср.арифметического по колонкам, вывод на экран
void GetAvgColumns(int[,] array){
    double [] summ = new double [array.GetLength(1)];

    WriteLine("\nДля контроля: ");
    PrintIntTable(array);

    WriteLine($"\n===== Среднее арифмитическое колонок для {array.GetLength(0)} строк ======");
    Write("[ ");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ[j] += Convert.ToDouble(array[i,j]);
        }
//        Write($"({summ[j]})"); использовал для отладки
        summ[j]/=array.GetLength(0);
        Write($"{summ[j]:f2} ");

    }
    Write("] ");
    WriteLine("===========");

}

Random randomInput= new Random();

//задаём случайную размерность массива
int lines = randomInput.Next(1,10);
int columns = randomInput.Next(1,10);

int [] minmax = GetCommaInput("введите минимальное и максимальное значения ячеек: ");

int min =  minmax[0];
int max =  minmax[1];

int [,] someArray = CreateIntTable(lines,columns,min,max);

GetAvgColumns(someArray);
// GetAvgDiag(someArray); зачем-то повторил задачу урока
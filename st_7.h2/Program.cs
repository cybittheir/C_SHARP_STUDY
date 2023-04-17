/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/


using System;
using static System.Console;

int [] GetCommaInput(string prompt)
{
    int [] result = new int[2];
    Write(prompt);

    string [] invalues=ReadLine().Split(",");

    result[0]=Convert.ToInt32(invalues[0]);
    result[1]=Convert.ToInt32(invalues[1]);
    return result;
}

double [,] CreateDoubleArray(int lines,int columns,int min,int max){

    double [,] result=new double[lines,columns];
    for (int i=0;i<lines;i++)
    {
        int number=0;
        double div=0.01;
        Random dRandom = new Random();

        for (int j=0;j<columns;j++)
        {
            number =dRandom.Next(min,max-1);
            div = dRandom.Next(0,100);
            result[i,j]=number + div/100;
        }
    }
    return result;
}

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

void CheckPoint(double[,] array, int [] point){
    
    string errMsg="Неверно указаны координаты. Нет такой ячейки";
    if(point[0]-1<0 || point[0]>array.GetLength(0) || point[1]-1<0 || point[1]>array.GetLength(1))
    {
        WriteLine(errMsg);
    } 
    else 
    {
        WriteLine($"\nBingo!!! попадание в точку!\nПо координате {point[0]},{point[1]} находится число {array[point[0]-1,point[1]-1]:f1};");
    }
    
    WriteLine("\nДля контроля: ");
    PrintDoubleArray(array);

}

Random randomInput= new Random();

int lines = randomInput.Next(1,10);
int columns = randomInput.Next(1,10);
int min =  randomInput.Next(-9,8);
int max =  randomInput.Next(min+1,10);

double [,] magicArray = CreateDoubleArray(lines,columns,min,max);

int [] pointCoord = GetCommaInput("введите координаты ячейки через запятую (отсчёт начинается с 1 до 10): ");

CheckPoint(magicArray,pointCoord);
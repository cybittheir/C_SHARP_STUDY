
/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

// Сортировка строки массива
void SortArrayLine(int [,] array,int line)
{

    int tmp=0;
    int flag=0; // флаг отсутствия замен в цикиле

    for (int i=1;i<array.GetLength(1);i++)
    {
        if (array[line,i]>array[line,i-1]) 
        {
            tmp=array[line,i-1];
            array[line,i-1]=array[line,i];
            array[line,i]=tmp;
            flag=1; // замена произошла, необходим новый прогон
        }
    }
        
// если была замена в цикле, запускаем процесс рекурсивно
    if (flag==1)
    {
        SortArrayLine(array,line);
    }
    
}

Clear();

int[] size=GetCommaInput("введите через запятую размеры массива(строки,колонки): ");
int[] nums=GetCommaInput("введите через запятую крайние значения элементов массива(min,max): ");
int[,]tmpArray=CreateIntArray(size[0],size[1],nums[0],nums[1]);

WriteLine("\n==== sourсe ====");
PrintIntArray(tmpArray);

for (int i=0;i<tmpArray.GetLength(0);i++)
{
    SortArrayLine(tmpArray,i);
}

WriteLine("\n**** after sorting ****");
PrintIntArray(tmpArray);


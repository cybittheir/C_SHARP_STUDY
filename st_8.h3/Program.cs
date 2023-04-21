
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



using System;
using static System.Console;

// приём пары новых данных через запятую
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

// формула вычисления элемента матрицы
int Number(int [,] firstArray,int [,] secondArray,int i, int j)
{
    int result = 0;

    for (int y = 0;y<firstArray.GetLength(1);y++)
    {
            result += firstArray[i,y]*secondArray[y,j];
    }
    
    return result;

}

// тело программы

int[] size1=GetCommaInput("введите через запятую размеры матрицы I (строки,колонки): ");
int[] nums1=GetCommaInput("введите через запятую крайние значения элементов матрицы I (min,max): ");
int[,]tmpArray1=CreateIntArray(size1[0],size1[1],nums1[0],nums1[1]);

int[] size2=GetCommaInput("введите через запятую размеры матрицы II (строки,колонки): ");
int[] nums2=GetCommaInput("введите через запятую крайние значения элементов матрицы II (min,max): ");
int[,]tmpArray2=CreateIntArray(size2[0],size2[1],nums2[0],nums2[1]);

Clear();

WriteLine("\n==  I  ==");
PrintIntArray(tmpArray1);
WriteLine("\n== II ==");
PrintIntArray(tmpArray2);

if (size1[1]==size2[0]) // проверка корректности введенных данных 
{

    WriteLine("\n== result ==");

    int [,] multArray = new int [tmpArray1.GetLength(0),tmpArray2.GetLength(1)];
    for (int i=0;i<tmpArray1.GetLength(0);i++)
    {
        for (int j=0;j<tmpArray2.GetLength(1);j++){
            multArray[i,j] = Number(tmpArray1,tmpArray2,i,j);
        }
    }

    PrintIntArray(multArray);
} 
else 
{
    WriteLine("\nОшибка!!!\nНельзя перемножить матрицы, так как количество столбцов матрицы I не равно количеству строк матрицы II");
}


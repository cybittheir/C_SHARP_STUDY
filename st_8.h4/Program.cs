/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using System;
using static System.Console;

// принимаем пару входных данных и возвращаем в массиве
int [] GetCommaInput(string prompt,int range)
{
    int [] result = new int[3];
    Write(prompt);

    string [] invalues=ReadLine().Split(",");

    for (int i=0;i<range;i++)
    {
    
        result[i]=Convert.ToInt32(invalues[i]);

    }

    return result;
}

bool InArray(int[,,]array,int query)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            for (int k=0;k<array.GetLength(2);k++)
            {
                if (array[i,j,k]== query) {return true;}
            }
        }
    }
    return false;
}

// генерация трехмерного массива целых чисел с задаваемыми размером и крайними значениями
int [,,] CreateIntArray(int lines,int columns, int deep,int min,int max){

    int [,,] result=new int[lines,columns,deep];

    for (int i=0;i<lines;i++)
    {
        Random dRandom = new Random();

        for (int j=0;j<columns;j++)
        {
            for (int k=0;k<deep;k++)
            {
                int tmp = dRandom.Next(min,max-1);
                while (InArray(result,tmp)){
                    tmp = dRandom.Next(min,max-1);
                }
                result[i,j,k]=tmp;
            }
        }
    }
    return result;
}

// вывод на экран массива чисел
void PrintIntArray(int [,,]array)
{
    for (int i=0;i < array.GetLength(0);i++)
    {
        Write("[ ");

        for (int j=0;j<array.GetLength(1);j++)
        {
            for (int k=0;k<array.GetLength(2);k++)
            {
                Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            if (j<array.GetLength(1)-1){Write(" | ");}
        }
        WriteLine("]");
    }
}


Clear();

int [] size = GetCommaInput("введите через запятую размер трехмерной матрицы(строки, колонки, глубина): ",3);
int [] nums = GetCommaInput("введите через запятую целые крайние значения элементов(min,max): ",2);

int val = size[0]*size[1]*size[2];
int range=nums[1]-nums[0];

// проверка чтобы диапазон был больше объема матрицы
if (val>range)
{
    WriteLine("\nОшибка ввода!\nРасширьте границы или уменьшите размер матрицы. Иначе создание уникальных элементов невозможно.");
    return;
} else 
{
//    int [,,] newArr = CreateIntArray(size[0],size[1],size[2],nums[0],nums[1]);
    PrintIntArray(CreateIntArray(size[0],size[1],size[2],nums[0],nums[1]));
}

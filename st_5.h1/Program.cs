/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
s*/

// генератор массива
int [] genArray (int len,int min,int max)
{
    int [] array=new int [len];
    Random myRandom=new Random();
    for (int i=0;i<len;i++){
        array[i] = myRandom.Next(min,max+1);
    }
    return array;
}

// выбираем четные 
int calcEven(int [] array)
{
    int result = 0;
    foreach(int val in array)
    {
        if (val%2==0) result+=1;
    }
    return result;
}

// запрос на длину массива
int getLen(string prompt)
{
    int result=-1;
    while (result <0 || result >9)
    {
        Console.Clear();
        Console.Write($"{prompt}: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

// запрос на продолжение программы или выход из неё
bool toContinue()
{
    Console.Write("Press Enter to continue OR 'Q' for Exit... ");
        
    if (Console.ReadLine().ToLower()=="q") {
        Console.WriteLine("Bye");
        return false;
    }
    
    Console.Clear();
    return true;
}

// основное тело программы
Console.Clear();

int min = 100;
int max = 999;

int len=-1;
bool jobs=true;

while (jobs){

    len = getLen("Введите длину массива (<10) или 0 для выхода");

    if (len==0) 
    {
        Console.WriteLine("Exit");
        return;
    }

    int [] someArray=genArray(len,min,max);

    Console.Write($"[{String.Join(":",someArray)}] -> ");
    Console.WriteLine($"{calcEven(someArray)}");
    jobs=toContinue();
}
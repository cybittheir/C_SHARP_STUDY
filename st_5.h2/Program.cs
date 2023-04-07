/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


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

// выбираем и складывем нечетные числа 
int sumOdd(int [] array)
{
    int result = 0;
    foreach(int val in array)
    {
        if (val%2!=0) result+=val;
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

int min = -99;
int max = 99;

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
    Console.WriteLine($"{sumOdd(someArray)}");
    jobs=toContinue();
}
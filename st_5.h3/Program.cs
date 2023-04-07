/*

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/


// генератор массива без использования метода RandomDouble. Было интересно самому сделать
double [] genArray (int len,int min,int max)
{
    double [] array=new double [len];
    Random myRandom=new Random();
    double a = 0;
    for (int i=0;i<len;i++){
        array[i] = myRandom.Next(min,max+1);
        a = myRandom.Next(0,100);
        array[i]+=a/100;
    }
    return array;
}

// основная математика: выбираем мин и макс и находим разницу
double diffMinMax(double [] array)
{
    double min = array[0];
    double max = array[0];
    foreach(double val in array)
    {
        min = min > val ? val : min;
        max = max < val ? val : max;

    }
    return max-min;
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

    double [] someArray=genArray(len,min,max);

    Console.Write($"[ {String.Join(" : ",someArray)} ] -> ");
    Console.WriteLine($"{diffMinMax(someArray):f2}");
    jobs=toContinue();
}
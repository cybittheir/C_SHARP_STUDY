/*
    Задача 27: Напишите программу, которая принимает на вход число 
    и выдаёт сумму цифр в числе.
    
    452 -> 11
    82 -> 10
    9012 -> 12
*/

// получение или генерация входного числа
int getNumber(string prompt)
{
    int result=-1;

    while (result<0)
    {
        Console.Clear();
        Console.Write($"{prompt}: ");
        result = int.Parse(Console.ReadLine());
        if (result==0)
        {
            result = new Random().Next(1,10000000);
        }
    }
    return result;
}

// вариант 1 длинный, с разбивкой на дополнительные методы
// сyмма чисел массива int array

int mySum(int [] array){
    
    int sum = 0;

    foreach (int i in array)
    {
        sum += i;
    }
    return sum;
}

// перевод цисла в массив. в обратном порядке. 
// Для дальнейшего использования в задаче правильный порядок не нужен

int [] intToArray(int number){
    
    int [] digArray = new int[lenNumber(number)];
    int i = 0;

    while (number>0)
    {
        digArray[i]=number%10;
        number/=10;
        i++;
    }
    return digArray;
}

// вычисление разрядности числа для инициализации массива
int lenNumber(int number)
{
    int i = 0;
    while(number>0)
    {
        number/=10;
        i++;
    }
    return i;
}

// вариант 2. Коротко. Только вычисление
int digSum(int number)
{
    int result=0;
    while(number>0)
    {
        result += number%10;
        number/=10;
    }
    return result;
}

// основное тело программы

int number=getNumber("Введите число или 0 для генерации случайного");

Console.Write($"Сумма цифра числа {number} равна ");
Console.Write($"{mySum(intToArray(number))} ");
Console.WriteLine($"(вариант 2: {digSum(number)})");

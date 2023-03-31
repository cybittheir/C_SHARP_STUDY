// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 
int Entrance (string greeting)
{
    int result=1;
    int minNumber=100;
    int maxNumber=2139999999;
    
    while ((result>0 && result<minNumber) || result>maxNumber)
    {
        Console.Clear();
        Console.WriteLine(greeting + ":");
        result = int.Parse(Console.ReadLine());
        if (result==0)
        {
            result=new Random().Next(minNumber,maxNumber);
        }
    }

    return result;
}

// получаем количество цифр в числе
int GetDigitalNum(int number)
{
    int i = 0;

    while (number>0)
    {
        number/=10;
        i++;
    }

    return i;

}

// проверка нв четность
bool CheckOdd(int number)
{
    if (number%2!=0)
    {
        return true;
    } 
    return false;
}

// зеркалим цифры
int MirrorDig(int number)
{
    int dig=0;

    while(number >0)
    {
        dig=dig*10 + number%10;
        number/=10;
    }

    return dig;
}

// основная часть программы
    
    int number = Entrance ("Введите любое число от 100 до 10000000 или 0 для выбора случайного");

    int divisor2 = Convert.ToInt32(Math.Pow(10,GetDigitalNum(number)/2)); // получаем делитель для разделения числа на две части
    int divisor1 = divisor2;

    // если число цифр нечетное, добавляем делителю 0
    if (CheckOdd(GetDigitalNum(number)))
    {
        divisor1*=10;
    }
 
    if (number/divisor1==MirrorDig(number%divisor2))
    {
        Console.WriteLine($"Bingo! {number} - палиндром!\nЕсли число случайное, то вы - счастливчик!");
    } 
    else
    {
        Console.WriteLine($"Увы, {number} - обычное число");

    }


/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Требуется уже какая-тообработка ошибок

// своя версия метода RandomDouble
double myRandomDouble(int a,int b)
{
    double result = 0;
    double tmp = 0;
    Random qRandom = new Random();

    result = qRandom.Next(a,b);
    tmp = qRandom.Next(0,100);
    result+=tmp/100;
    
    return result;
}

// Принимаем число. 
double getNum(string prompt)
{
    double result = 0;
    Console.Write(prompt);

    result = Convert.ToDouble(Console.ReadLine());

// если 0, генерируем случайное    
    if (result == 0)
    {
        result=myRandomDouble(2,100);
        Console.WriteLine($"{result}");
    }
    
    return result;
}

// принимаем степень числа
int getInt(string prompt)
{
    int result=-1;

// степень только > 0. Если 0 - генерируем случайное число
    while (result<0)
    {
        Console.Write(prompt);
        result = int.Parse(Console.ReadLine());

        if (result == 0)
        {
            result=new Random().Next(2,10);
            Console.WriteLine(result);
        }
    }
    return result;
}

// своя версия Math.Pow()
double myPow(double x,int y)
{
    double result = x;
    for (int i=2;i<=y;i++)
    {
        result *= x;
    }
    return result;
}

// Основное тело программы
double x = 0;
int y = 1;

// в цикле, пока число не равно 1. Иначе - выход
while (x!=1)
{
    Console.Clear();
    x = getNum("Введите число\nили \n0 - для случайного,\n1 - для выхода из программы: ");
    if (x != 1)
    {
        y = getInt("Введите степень числа или 0 для случайного: ");
        Console.WriteLine($"{x} в степени {y} равно {myPow(x,y):f2};");
        Console.WriteLine("Press ENTER to continue...");
        Console.ReadLine();
    } 
    else 
    {
        Console.WriteLine("The END;");
        return;
    }
}


int Entrance()
{
    Console.WriteLine("Введите число или 0 для рандомного числа, или 1 для выхода:");
    
    int number; 
    
    if ((number=int.Parse(Console.ReadLine()))==0)
    {
        number =new Random().Next(2,12000000);
    }
    Console.Clear();

    return number;

}

bool ValidNumber(int number)
{
    if (number<100)
    {
        Console.WriteLine("третьей цифры нет\n=======");
        return false;
    }
    return true;
}

void NumDigital()
{
    int number=-1;
    int tmp=0;
    while((number=Entrance())!=1)
    {
        if (ValidNumber(number))
        {
            tmp=number;
            while (tmp>999)
            {
                tmp=tmp/10;
            }
//            Console.WriteLine($"Третья цифра от({number}): {(tmp-(tmp/100)*100)%10}");
            Console.WriteLine($"Третья цифра от({number}): {tmp%10}\n=======");
        }

    }

    return;
}

Console.Clear();

// Решение задачи №13
NumDigital();

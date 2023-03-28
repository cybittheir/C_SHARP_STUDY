
int Entrance()
{
    Console.WriteLine("Введите число или 0 для рандомного числа, или 1 для выхода:");
    
    int number; 
    
    if ((number=int.Parse(Console.ReadLine()))==0)
    {
        number =new Random().Next(2,12000000);
    }

    return number;

}

void NumDigital()
{
    int number=-1;
    int tmp=0;
    while((number=Entrance())!=1)
    {
        if (number<100)
        {
            Console.WriteLine("третьей цифры нет");
        } 
        else 
        {
            tmp=number;
            while (tmp>999)
            {
                tmp=tmp/10;
            }
//            Console.WriteLine($"Третья цифра от({number}): {(tmp-(tmp/100)*100)%10}");
            Console.WriteLine($"Третья цифра от({number}): {tmp%10}");
        }

    }

    return;
}

Console.Clear();

// Решение задачи №13
NumDigital();

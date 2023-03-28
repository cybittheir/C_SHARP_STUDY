
// Решение задачи №10

int Entrance(string greeting)
{
    Console.WriteLine(greeting);
    return int.Parse(Console.ReadLine());

}

void CalculateSecDig(string greeting){

    int number=1;
    while (number!=0)
    {
        number=Entrance(greeting);
        Console.Clear();

        if (number<100 || number >999){
            if (number==0)
            { 
                return;
            }
        } else {
//            Console.WriteLine($"{number}. Вторая цифра: {(number-(number/100)*100)/10}");
            Console.WriteLine($"{number}. Вторая цифра: {number/10%10}\n======");
        }
    }
    return;
}

CalculateSecDig("Введите трехзначное число (0 для выхода):");

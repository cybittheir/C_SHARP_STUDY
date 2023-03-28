// решение задачи №13

Console.Clear();
Console.WriteLine("Введите число или 0 для рандомного числа:");
int number=int.Parse(Console.ReadLine());

if (number==0){
    number =new Random().Next(0,12000000);
}
if (number<100){
    Console.WriteLine("третьей цифры нет");
} else {
    int tmp=number;
    while (tmp>999){
        tmp=tmp/10;
    }
// Решение задачи №13
//    Console.WriteLine($"Третья цифра от({number}): {(tmp-(tmp/100)*100)%10}");
    Console.WriteLine($"Третья цифра от({number}): {tmp%10}");
}



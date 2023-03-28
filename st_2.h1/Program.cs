Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int number=int.Parse(Console.ReadLine());

while(number<100 || number >999){
    Console.Clear();
    Console.WriteLine("Введите трехзначное число:");
    number=int.Parse(Console.ReadLine());
}
// Решение задачи №10
Console.WriteLine($"Вторая цифра: {(number-(number/100)*100)/10}");
Console.WriteLine($"Вторая цифра: {number/10%10}");


Console.Clear();
Console.WriteLine("Введите число:");

int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");

int num2=int.Parse(Console.ReadLine());

if (Math.Pow(num1,2)==num2) {

    Console.WriteLine($"{num2} - квадрат {num1}");

} else if (Math.Pow(num2,2)==num1) {

    Console.WriteLine($"{num1} - квадрат {num2}");

} else {
    
    Console.WriteLine("Нет");

}

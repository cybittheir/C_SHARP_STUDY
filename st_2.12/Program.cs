Console.Clear();

Console.WriteLine("Введите число:");
int num1=Convert.ToInt32(Console.ReadLine());

int num2=new Random().Next(10,100);

if (num1>num2) {
    if (num1%num2==0) {
        Console.WriteLine($"Числа {num1} и {num2} кратны");
    } else {
        int num3=num1%num2;
        Console.WriteLine($"Числа {num1} и {num2} НЕ кратны. Остаток: {num3} ");
    }
} else {
    if (num2%num1==0) {
        Console.WriteLine($"Числа {num2} и {num1} кратны");
    } else {
        int num3=num2%num1;
        Console.WriteLine($"Числа {num2} и {num1} НЕ кратны. Остаток: {num3} ");
    }
}
Console.Clear();
Console.WriteLine("Введите число:");

int num=int.Parse(Console.ReadLine());

string rest =" НЕ";

if (num%7==0 && num%23==0) {
    rest="";
} 

Console.WriteLine($"Число {num}{rest} кратно и 7 и 23");

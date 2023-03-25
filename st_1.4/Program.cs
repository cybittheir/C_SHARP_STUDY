/*
Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает **последнюю** цифру этого числа.
    
    456 -> 6
    
    782 -> 2
    
    918 -> 8

*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

while(number<100 || number>999){
  Console.WriteLine("Ошибка");
  Console.Write("Введите число заново: ");
  number = int.Parse(Console.ReadLine());
} 

Console.Write($"последняя цифра - {number%10}");


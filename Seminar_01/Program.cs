/*** Задача 01***

Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49


*/

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr=number*number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");
int sqr1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"{number} во второй степени равен {sqr1}");

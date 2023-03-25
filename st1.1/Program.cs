/*
Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{Math.Pow(number2,2)==number1}");

/* if (Math.Pow(number2,2))  
*
int sqr=number1*number1;

if(number2==sqr){
Console.WriteLine($"Второе число {number2} равно квадрату первого {number1}");    
} else {
Console.WriteLine($"Второе число {number2} НЕ равно квадрату первого {number1}");    

}
*/

  /*а как условие? не вижу его*/

 
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if(number==1){
    Console.WriteLine("Понедельник");
} else if(number==2){
    Console.WriteLine("Вторник");
} else if(number==3){
    Console.WriteLine("Среда");
} else if(number==4){
    Console.WriteLine("Четверг");
} else if(number==5){
    Console.WriteLine("Пятница");
} else if(number==6){
    Console.WriteLine("Суббота");
} else if(number==7){
    Console.WriteLine("Воскресенье");
} else {
    Console.WriteLine("Такого дня недели нет");
}

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


while(number>7 || number<1){
  Console.WriteLine("Ошибка ввода");    
  Console.Write("Введите число заново: ");
  number = int.Parse(Console.ReadLine());
} 

if (number==7) {
  Console.WriteLine("Воскресенье");    
} else if (number==6) {
  Console.WriteLine("Суббота");    
} else if (number==5) {
  Console.WriteLine("Пятница");    
} else if (number==4) {
  Console.WriteLine("Четверг");    
} else if (number==3) {
  Console.WriteLine("Среда");    
} else if (number==2) {
  Console.WriteLine("Вторник");    
} else {
  Console.WriteLine("Понедельник");    
}


  /*  ошибку не показывает. Путаница с файлами. Минутку */
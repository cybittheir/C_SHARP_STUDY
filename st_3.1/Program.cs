// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер четверти:");

int number=int.Parse(Console.ReadLine());

if (number==1) {
    Console.WriteLine("X > 0 И Y > 0");
} else if (number==2) {
    Console.WriteLine("X < 0 И Y > 0");
} else if (number==3) {
    Console.WriteLine("X < 0 И Y < 0");
} else if (number==4) {
    Console.WriteLine("X > 0 И Y < 0");
} else {
    Console.WriteLine("Ошибка ввода");
}

switch (number) {
    case 1:
        Console.WriteLine("X > 0 И Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0 И Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0 И Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0 И Y < 0");
        break;
    default:
        Console.WriteLine("Ошибка ввода");
        break;
}
// решение задачи №15

// вариант первый, лучший

Console.Clear();
Console.WriteLine("Введите цифру дня недели:");
int number=int.Parse(Console.ReadLine());

if (number==6 ||number==7){
    Console.WriteLine("Выходной.");
} else if (number <1 || number>7){
    Console.WriteLine("Ошибка ввода.");
} else {
    Console.WriteLine("Трудовыебудни");
}

// вариант второй. Просто потому что есть
switch (number)
{
    case 7:
        Console.WriteLine("2.Выходной.");
        break;
    case 6:
        Console.WriteLine("2.Выходной.");
        break;
    case 5:
        Console.WriteLine("2.Трудовыебудни");
        break;
    case 4:
        Console.WriteLine("2.Трудовыебудни");
        break;
    case 3:
        Console.WriteLine("2.Трудовыебудни");
        break;
    case 2:
        Console.WriteLine("2.Трудовыебудни");
        break;
    case 1:
        Console.WriteLine("2.Трудовыебудни");
        break;
    default:
        Console.WriteLine("2.Ошибка ввода.");
        break;

}

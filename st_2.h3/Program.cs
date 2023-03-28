
// решение задачи №15

int Entrance(){

    Console.WriteLine("Введите цифру дня недели или 0 для выхода:");
    return int.Parse(Console.ReadLine());

}

string MakeChoose(){

    int number = Entrance();

    string result ="";

    if (number==6 ||number==7){
        result = "Выходной.";
    } else if (number>7){
        result = "Ошибка ввода.";
    } else if (number == 0) {
        result = "Выход";
    } else {
        result = "Трудовыебудни";
    }

    return result;
}

Console.Clear();

string str="";

while(str != "Выход") {
    Console.WriteLine(str = MakeChoose());
}

Console.WriteLine("Финиш");




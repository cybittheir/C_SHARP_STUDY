/*

Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

*/

void calcPositive(string [] array) {
    int result=0;
    foreach(string val in array) {
        if (Convert.ToInt32(val)>0){
            result++;
        }
    }
    Console.WriteLine(result);
}

string [] inputArray(string prompt) {

    Console.Write($"{prompt}:");
    string [] newArray=Console.ReadLine().Split(",");
    Console.Write(String.Join("; ",newArray) + " -> ");
    return newArray;
}

calcPositive(inputArray("Введите числе через запятую"));
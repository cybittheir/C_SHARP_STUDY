/*

Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/
const int FACTOR = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 0;
const int LINE2 = 1;


double [] findPoint(double [] lineFirst,double[]lineSecond){

    double x = (lineSecond[CONSTANT]-lineFirst[CONSTANT])/(lineFirst[FACTOR]-lineSecond[FACTOR]);
    double y = lineFirst[FACTOR]*x + lineFirst[CONSTANT];
    double[]result={x,y};
    return result;
}

double [] getLine(string prompt,int number) {
    Console.WriteLine($"{prompt} {number+1}:");
    return getNums();
}

double [] getNums(){
    
    double []nums=new double[2];
    nums[FACTOR]=getValue("Введите коффициент:");
    nums[CONSTANT]=getValue("Введите константу:");
    return nums;

}

double getValue(string prompt){
    
    Console.Write(prompt);
    double val=Convert.ToDouble(Console.ReadLine());
    return val;

}

bool checkValid(double []line1,double []line2){

    if (line1[FACTOR]==line2[FACTOR] && line1[CONSTANT]==line2[CONSTANT]){
        Console.WriteLine("Линии совпадают");
        return false;
    } else if (line1[FACTOR]==line2[FACTOR]) {
        Console.WriteLine("Линии параллельны");
        return false;
    } else {
        return true;
    }
}

double [] lineFirst;
double [] lineSecond;

string prompt="Введите данные линии №";
lineFirst = getLine(prompt,LINE1);
lineSecond = getLine(prompt,LINE2);

Console.Write($"b1 = {lineFirst[FACTOR]}, k1 = {lineFirst[CONSTANT]}, b2 = {lineSecond[FACTOR]}, k2 = {lineSecond[CONSTANT]} -> ");

if (checkValid(lineFirst,lineSecond)){
    double [] point=findPoint(lineFirst,lineSecond);
    Console.WriteLine($"Точка пересечения линий: ({point[X_COORD]:f2}; {point[Y_COORD]:f2})");
}
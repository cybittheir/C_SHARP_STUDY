/*

Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

double [] findPoint(int b1,int k1,int b2, int k2){

    double x = (Convert.ToDouble(b2)-Convert.ToDouble(b1))/(Convert.ToDouble(k1)-Convert.ToDouble(k2));
    double y = Convert.ToDouble(k1)*x + Convert.ToDouble(b1);
    double[]result={x,y};
    return result;
}

int a=6;
int b=3;
int c=4;
int d=9;

Console.Write($"b1 = {a}, k1 = {b}, b2 = {c}, k2 = {d} -> ");
double [] point=findPoint(a,b,c,d);
Console.WriteLine($"({point[0]:f2}; {point[1]:f2})");
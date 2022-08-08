/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
*/
Console.WriteLine("Enter b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double DotX(double k1, double b1, double k2, double b2)
{
    double X = 0;
    X = ((b2 - b1) / (k1 - k2));
    return X;
}

double X = DotX(k1, b1, k2, b2);

double DotY(double X, double k2, double b2)
{
    double Y = 0;
    Y = k2 * X + b2;
    return Y;
}
double Y = DotY(X, k2, b2);

Console.WriteLine($"Crosspoint is: ({string.Format("{0:0.###} ", X)}; {string.Format("{0:0.###} ", Y)})");
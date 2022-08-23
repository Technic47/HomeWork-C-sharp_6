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
    double result = ((b2 - b1) / (k1 - k2));
    return result;
}

double x = DotX(k1, b1, k2, b2);

double DotY(double x, double k2, double b2)
{
    double result = k2 * x + b2;
    return result;
}

double y = DotY(x, k2, b2);

Console.WriteLine($"Crosspoint is: ({string.Format("{0:0.###} ", x)}; {string.Format("{0:0.###} ", y)})");
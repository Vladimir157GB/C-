
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int InputPoint(string pointName)
{
    Console.WriteLine($"Введите число {pointName}: ");
    int point = Convert.ToInt32(Console.ReadLine());
    return point;
}

void CheckIntersection(double B1, double K1, double B2, double K2)
{
    double x = (B2 - B1) / (K1 - K2);
    double y = K1 * x + B1;
    double[] IntersectionPointArr = new double[]{x, y};
    System.Console.WriteLine($"{IntersectionPointArr[0]} {IntersectionPointArr[1]} ");
}

double b1 = InputPoint("B1");
double k1 = InputPoint("K1");
double b2 = InputPoint("B2");
double k2 = InputPoint("K2");
CheckIntersection(b1, k1, b2, k2);

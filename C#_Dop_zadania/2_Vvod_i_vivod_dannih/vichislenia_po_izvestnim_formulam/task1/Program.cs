// Составить программу:
//а) вычисления значения функции y=7x2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a2+7a+12 при любом значении а.

Console.WriteLine("Введите число X");
double x = Convert.ToInt32(Console.ReadLine());
double result = (Math.Pow(7, 2) + 3 * x + 4);
System.Console.WriteLine($"Y = {result}");

Console.WriteLine("Введите число X2");
double x2 = Convert.ToInt32(Console.ReadLine());
double result2 = (12 * Math.Pow(x2, 2) + 7 * x2 + 12);
System.Console.WriteLine($"Y = {result2}");
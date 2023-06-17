// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Возведение в степень
//double number = 9;
//System.Console.WriteLine(Math.Pow(number, 2));

// Извлечение квадратного корня
//System.Console.WriteLine(Math.Sqrt(number));

// Округление дробного числа
//double num = 1.123213213213;
//System.Console.WriteLine(Math.Round(num, 2));

// Комбинация
// System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(num, 3)), 2));

System.Console.Write("Введите координату Х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Расстояние между точками {(Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2 - y1, 2)), 2))}");
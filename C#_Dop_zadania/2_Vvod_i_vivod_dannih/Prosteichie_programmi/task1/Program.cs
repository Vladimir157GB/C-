//Вывести на экран число  с точностью до сотых.

Random rnd = new Random();
double number = rnd.NextDouble() *(100-0) + 0;
System.Console.WriteLine($"{number}");
System.Console.WriteLine($"После округления получается {Math.Round(number, 2)}");
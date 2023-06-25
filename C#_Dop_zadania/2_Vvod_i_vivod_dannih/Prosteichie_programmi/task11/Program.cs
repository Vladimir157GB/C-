
//Составить программу вывода на экран «столбиком» четырех любых чисел.

Random rnd = new Random();
for (int i = 0; i < 4; i++)
{
    int n = rnd.Next(0, 10);
    Console.WriteLine($"{n}");
}
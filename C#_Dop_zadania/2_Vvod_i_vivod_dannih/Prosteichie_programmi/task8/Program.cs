// Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(1,10);
    }
    return arr;
}

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
System.Console.WriteLine(string.Join(" ", array));

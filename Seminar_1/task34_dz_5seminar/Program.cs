//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] Create3DigitArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}

int countChetnost = 0;

int CheckOutChetnost(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countChetnost++;
        }
    }
    return countChetnost;
}

Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = Create3DigitArray(length);
System.Console.WriteLine(string.Join("; ", array));
int count = CheckOutChetnost(array);
System.Console.WriteLine($"В полученном массиве {count} четных чисел");


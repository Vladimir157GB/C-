//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] randomArr(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

int sumChetNumbers = 0;

int CheckOutChetnost(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumChetNumbers += arr[i];
        }
    }
    return sumChetNumbers;
}

Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = randomArr(length);
System.Console.WriteLine(string.Join("; ", array));
int count = CheckOutChetnost(array);
System.Console.WriteLine($"Сумма элементов, расположенных на нечетных позициях, равна {sumChetNumbers}");
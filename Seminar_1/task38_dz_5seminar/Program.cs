//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] randomArr(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() *(100-0) + 0), 2);
    }
    return arr;
}

double FindMinMax(double[] arr)
{
    int i = 0;
    double max = arr[i];
    double min = arr[i];
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= max)
        {
        max = arr[i];
        }
            else if (arr[i] <= min)
            {
            min = arr[i];   
            }
    } 
    double result = max - min;
    return result;
}
Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = randomArr(length);
System.Console.WriteLine(string.Join("; ", array));
System.Console.WriteLine($"Разница между максимальным и минимальным значением массива составляет {FindMinMax(array)}");
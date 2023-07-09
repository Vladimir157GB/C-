//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbersNto1(int numberN)
{
    if (numberN > 1)
    {
        System.Console.Write($"{numberN}, ");
        PrintNumbersNto1(numberN - 1);
    }
    else
    {
        System.Console.Write($"{numberN}");
    }
}

System.Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
PrintNumbersNto1(numberN);
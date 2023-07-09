//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int SumNumbersFromN2M(int n, int m)
{
    int sum = 0;
    if (n > m)
    {
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
    }
    else 
    {
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }  
    }
    return sum;
}

System.Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{SumNumbersFromN2M(numberN, numberM)}");
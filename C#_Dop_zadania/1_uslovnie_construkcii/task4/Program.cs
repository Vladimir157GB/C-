//В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
//Напишите консольную программу, в которую пользователь вводит сумму вклада. 
//Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. 
//Если сумма вклада больше 200, то начисляется 10%. 
//В конце программа должна выводить сумму вклада с начисленными процентами.
//Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())

double CheckOutPercent(double sum)
{
    if (sum < 100)
    {
        return 0.05;
    }
    else if (sum >= 200)
    {
        return 0.1;
    }
    else
    {
        return 0.07;
    }
}

double CalculatePercent (double sum, double percent)
{
    double result = sum + sum*percent;
    return result;
}

Console.WriteLine("Введите сумму вклада");
double summa = Convert.ToDouble(Console.ReadLine());
double percent = CheckOutPercent(summa);
double result = CalculatePercent(summa, percent);
System.Console.WriteLine($"Сумма вклада с начисленными процентами {result}");
// Упражнение 1
// Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. 
//А программа сранивает два введенных числа и выводит на консоль результат сравнения 
//(два числа равны, первое число больше второго или первое число меньше второго).

void CheckOutNumbers (int numA, int numB)
{
        if (numA < numB)
    {
        System.Console.WriteLine($"Число {numA} меньше числа {numB}");
        return;
    }
    else if (numA > numB)
    {
        System.Console.WriteLine($"Число {numA} больше числа {numB}");
        return;
    }
    else
    {
        System.Console.WriteLine($"Число {numA} рано числу {numB}");
        return;
    }
}

Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Б");
int numberB = Convert.ToInt32(Console.ReadLine());
CheckOutNumbers(numberA, numberB);

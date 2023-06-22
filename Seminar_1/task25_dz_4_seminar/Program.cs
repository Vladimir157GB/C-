// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int expA2B (int number, int exp)
{
    int result = 1;
    for (int i = 0; i < exp; i++)
    {
        result = result * number;
    }
    return result;
}

bool validexp (int exp)
{
    if (exp % 1 == 0 && exp > 0)
    {
    return true;
    }
    System.Console.WriteLine($"Число {exp} должно быть натуральным");
    return false;
}


Console.WriteLine("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int exp = Convert.ToInt32(Console.ReadLine());
int expresult = 0;
if (validexp(exp))
{
    expresult = expA2B(number, exp);
    System.Console.WriteLine($"Число {number} в {exp} степени равно {expresult}");
}


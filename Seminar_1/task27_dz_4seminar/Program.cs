
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// -452 = 3

int sumDigits(int number)
{
string numberStr = number.ToString();
System.Console.WriteLine($"Количество чисел - {numberStr}");
    char[] numberArr = numberStr.ToCharArray();
    int countDigit = numberArr.Length;
    int sum = 0;
    for (int i = 0; i <  countDigit; i++)
    {
        sum = sum + numberArr[i];
        System.Console.WriteLine($"Число - {numberArr[i]}");
        System.Console.WriteLine($"Сумма - {sum}");
    }
    return sum;

}
//while (number > 0)
//{
//    sum = sum + number % 10;
//    number = number / 10;
//}
//return sum;
//}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = sumDigits(number);
System.Console.WriteLine($"Количество чисел - {result}");
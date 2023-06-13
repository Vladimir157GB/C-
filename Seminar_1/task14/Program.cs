//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

bool OddEven(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (OddEven(number))
{
    System.Console.WriteLine($"Число {number} кратно числам 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {number} не кратно числам 7 и 23");
}
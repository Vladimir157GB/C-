
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int CheckPositivNumbers()
{
    Console.WriteLine("Введите количество чисел М: ");
    int countNumbers = Convert.ToInt32(Console.ReadLine());
    int countPositivNumbers = 0;
    for (int i = 0; i < countNumbers; i ++)
    {
        Console.WriteLine("Введите число М: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            countPositivNumbers++;
        }  
    }
    return countPositivNumbers;
}

System.Console.WriteLine($"Вы ввели {CheckPositivNumbers()} чисел больше 0");
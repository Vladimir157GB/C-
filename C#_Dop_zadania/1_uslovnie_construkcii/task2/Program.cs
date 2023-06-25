
//Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
//Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". 
//Иначе программа выводит сообщение "Неизвестное число".


void CheckOutNumber(int num)
{
    if (num > 5 && num < 10)
    {
        System.Console.WriteLine("Число больше 5 и меньше 10");
        return;
    }
    else
        System.Console.WriteLine("Неизвестное число");
        return;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckOutNumber(number);

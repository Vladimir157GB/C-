
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
//Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". 
//Иначе программа выводит сообщение "Неизвестное число".

void CheckOutNumber(int num)
{
    if (num == 5 || num == 10)
    {
        System.Console.WriteLine("Число либо равно 5, либо равно 10");
        return;
    }
    else
    {
        System.Console.WriteLine("Неизвестное число");
        return;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt16(Console.ReadLine());
CheckOutNumber(number);
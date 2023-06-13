//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.Write("Понедельник - не выходной");
}
else if (day == 2)
{
    Console.Write("Вторник - не выходной");
}
else if (day == 3)
{
    Console.Write("Среда - не выходной");
}
else if (day == 4)
{
    Console.Write("Четверг - не выходной");
}
else if (day == 5)
{
    Console.Write("Пятница - не выходной");
}
else if (day == 6)
{
    Console.Write("Суббота - выходной! Ура!");
}
else if (day == 7)
{
    Console.Write("Воскресенье - выходной! Ура!");
}
else
{
    Console.Write("Такого дня недели не существует");
}
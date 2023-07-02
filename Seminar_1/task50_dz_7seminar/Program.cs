//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

void FillMatrixWithRandom(double[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() *(100-(-100)) + (-100)), 2);
        }
    }
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void CheckOutPosition(double[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        System.Console.Write($"{matrix[i-1, j-1]} ");
    }
    else
    {
        System.Console.Write("Такого элемента не существует");
    }
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine("Введите номер строки: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца: ");
int column1 = Convert.ToInt32(Console.ReadLine());
CheckOutPosition(matrix, row1, column1);
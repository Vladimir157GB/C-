//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void FillSpiralArray(int[,] matrix)
{
    int rowNew = matrix.GetLength(0);
    int columnNew = matrix.GetLength(1);
    int number = 1;
    int rowStart = 0;
    int rowEnd = rowNew - 1;
    int columnStart = 0;
    int columnEnd = columnNew - 1;

    while (rowStart <= rowEnd && columnStart <= columnEnd)
    {
        // Заполнение верхней строки
        for (int i = columnStart; i <= columnEnd; i++)
        {
            matrix[rowStart, i] = number++;
        }
        rowStart++;

        // Заполнение правого столбца
        for (int i = rowStart; i <= rowEnd; i++)
        {
            matrix[i, columnEnd] = number++;
        }
        columnEnd--;

        // Заполнение нижней строки
        if (rowStart <= rowEnd)
        {
            for (int i = columnEnd; i >= columnStart; i--)
            {
                matrix[rowEnd, i] = number++;
            }
            rowEnd--;
        }

        // Заполнение левого столбца
        if (columnStart <= columnEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, columnStart] = number++;
            }
            columnStart++;
        }
    }
}

void PrintMatrix(int[,] matrix)
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

System.Console.WriteLine("Введите кол-во строк матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов матрицы: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillSpiralArray(matrix);
PrintMatrix(matrix);
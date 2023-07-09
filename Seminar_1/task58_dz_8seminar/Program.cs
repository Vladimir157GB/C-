//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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

void MatrixMultiplicated(int[,] matrix1, int[,] matrix2, int[,] matrixMultiplicated)
{
        int row1 = matrix1.GetLength(0);
        int column1 = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int column2 = matrix2.GetLength(1);
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int k = 0; k < column1; k++)
            {
                matrixMultiplicated[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

System.Console.WriteLine("Введите кол-во строк 1 матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов 1 матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[row1, column1];
System.Console.WriteLine("Введите кол-во строк 2 матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов 2 матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[row2, column2];
int[,] matrixMultiplicated = new int[row1, column2];
FillMatrixWithRandom(matrix1);
PrintMatrix(matrix1);
System.Console.WriteLine();
FillMatrixWithRandom(matrix2);
PrintMatrix(matrix2);
System.Console.WriteLine();
if (column1 != row2)
{
Console.WriteLine("Умножение матриц невозможно!");
}
else
{
MatrixMultiplicated(matrix1, matrix2, matrixMultiplicated);
PrintMatrix(matrixMultiplicated);
}
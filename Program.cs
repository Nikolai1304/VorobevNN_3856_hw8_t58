// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int numRows = SetNumber("Rows ");
int numColumns = SetNumber("Columns ");
int numMaxValue = SetNumber("Max number ");
int numMinValue = SetNumber("Min number ");

int numRows1 = SetNumber("Rows 1");

// while (true)
// {
// if (numColumns!=numRows1 )
// break;
// else
// {
// System.Console.WriteLine("Неверный ввод, повторите");
// }
// }

int numColumns1 = SetNumber("Columns 1");
int numMaxValue1 = SetNumber("Max number 1");
int numMinValue1 = SetNumber("Min number 1");

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
var matrix1 = GetMatrix(numRows1, numColumns1, numMinValue1, numMaxValue1);
Print(matrix);
System.Console.WriteLine();
Print(matrix1);
System.Console.WriteLine();
if (matrix.GetLength(1) != matrix1.GetLength(0))
{
    Console.WriteLine("Эти матрицы умножить нельзя!");
}
else Print(MatrixMultiplication(matrix, matrix1));
                


int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
            resultMatrix[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }
    }
    return resultMatrix;
}
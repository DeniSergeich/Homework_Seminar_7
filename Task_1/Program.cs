using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());
double[,] array = GetArray(m, n, -10, 10);
PrintArray(array);

double[,] GetArray(int rows, int colomns, int min, int max)
{
    double[,] array = new double[rows, colomns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            array[i, j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]:f2} ");
        }
        WriteLine();
    }
}
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] resultArray = FillArray(rows, columns);
PrintArray(resultArray);
Write("Введите позицию элемента (строка, затем столбец) через пробел (начиная с 1): ");
string position = ReadLine();
int[] positionInArray = PositionInArray(position);
PrintResult(resultArray, positionInArray);

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
int[] PositionInArray(string position)
{
    string[] positionInArray = position.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] positionArray = new int[positionInArray.Length];
    for (int i = 0; i < positionArray.Length; i++)
    {
        positionArray[i] = int.Parse(positionInArray[i]);
    }
    return positionArray;
}
void PrintResult(int[,] array, int[] position)
{
    int rows = position[0];
    int columns = position[1];
    if (rows < array.GetLength(0) + 1 && columns < array.GetLength(1) + 1)
    {
        WriteLine($"Элемент находящийся на позиции [{rows},{columns}] равен: {array[rows - 1, columns - 1]}");
        return;
    }
    else
    {
        WriteLine("Такого элемента нет!");
    }
}
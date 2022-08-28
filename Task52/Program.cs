/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintAMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2},");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine("]");
    }
}

int[,] array = CreateMatrixRndInt(3, 4, 0, 9);
PrintAMatrix(array);
Console.Write($"Cреднее арифмитическое каждого столбца: ");

void AveRage(int[,] arrays)
{
    for (int i = 0; i < arrays.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arrays.GetLength(0); j++)
        {
            sum = sum + arrays[j, i];
        }
        double average = sum / arrays.GetLength(0);
        Console.Write($"{Math.Round(average, 1)}; ");
    }
}
AveRage(array);


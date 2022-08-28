//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}


Console.WriteLine("Введите позицию элемента:");
Console.Write("Стрoка:");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец:");
int colNum = Convert.ToInt32(Console.ReadLine());

void GetElement(int[,] matrix)
{
    if (rowNum > matrix.GetLength(0) || rowNum < 0 ||
       colNum > matrix.GetLength(1) || colNum < 0)
        Console.Write($"{rowNum-1}, {colNum-1} -> такого числа в массиве нет");

    else Console.Write($"Заданный элемент матрицы -> {matrix[rowNum-1, colNum-1]}");
}
int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
PrintAMatrix(array2D);
GetElement(array2D);


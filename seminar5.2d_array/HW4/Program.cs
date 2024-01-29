// Задача 4*(не обязательная): Задайте двумерный массив из
// целых чисел. Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен наименьший
// элемент массива. Под удалением понимается создание нового
// двумерного массива без строки и столбца.


int[,] FillMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rnd.Next(101);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrPrint)
{
    for (int i = 0; i < matrPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrPrint.GetLength(1); j++)
        {
            Console.Write($"{matrPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] MinNumberIndex(int[,] matrForInd)
{
    int MinNumber = matrForInd[0, 0];
    int[] MinNumberI = new int[2];
    for (int i = 0; i < matrForInd.GetLength(0); i++)
    {
        for (int j = 0; j < matrForInd.GetLength(1); j++)
        {
            if (MinNumber > matrForInd[i, j])
            {
                MinNumber = matrForInd[i, j];
                MinNumberI[0] = i;
                MinNumberI[1] = j;
            }
        }
    }
    return MinNumberI;
}

int[,] DelRowColMatrix(int[,] matr, int[] MinNumberIRC)
{
    int[,] resMatrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int rowInd = 0;
    int colInd = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (MinNumberIRC[0] != i)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (MinNumberIRC[1] != j)
                {
                    resMatrix[rowInd, colInd] = matr[i, j];
                    colInd++;
                }
            }
            rowInd++;
            colInd = 0;
        }
    }
    return resMatrix;
}

// Вызов функции
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = FillMatrix(rows, cols);
PrintMatrix(Matrix);
int[] MinNumberIndexRowsCols = MinNumberIndex(Matrix);
Console.WriteLine($"Индексы минимального числа в массиве: [ {string.Join("; ", MinNumberIndexRowsCols)} ]");
int[,] newMatrix = DelRowColMatrix(Matrix, MinNumberIndexRowsCols);
Console.WriteLine("Массив без строки и столбца, содержащих минимальный элемент: ");
PrintMatrix(newMatrix);
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д
int[,] FillMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();
    // Матрица, размер: rows стр и cols столбцов
    for (int i = 0; i < rows; i++) // i < matrix.GetLength(0), стр
    {
        // j, m, k
        for (int j = 0; j < cols; j++)// j < matrix.GetLength(1), столб
        {
            matrix[i, j] = rnd.Next(11); // [0; 10], 11 не попадет
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //  стр 
    {
        for (int j = 0; j < matr.GetLength(1); j++)// столб
        {
            Console.Write($"{matr[i, j]}\t"); // \t = 4 пробела
        }
        Console.WriteLine();
    }
}

int GetMainDiagonalSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++) //  стр 
    {
        for (int j = 0; j < matr.GetLength(1); j++)// столб
        {
            if (i == j) // номер стр = номер стл
            {
                sum += matr[i, j];// sum = sum + matr[i, j];
            }
        }
    }
    return sum;
}

// Вызовы функции
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] res = FillMatrix(rows, columns);
PrintMatrix(res); // ДО
Console.Write("Результат: ");
Console.Write($"{GetMainDiagonalSum(res)}");
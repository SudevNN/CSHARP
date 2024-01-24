// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Матрица - прямоугольная таблица размером m на n
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

void SquareElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //  стр 
    {
        for (int j = 0; j < matr.GetLength(1); j++)// столб
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i, j] *= matr[i, j]; // matr[i, j] = matr[i, j] * matr[i, j]
            }
        }

    }
}


// Вызовы функции
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] res = FillMatrix(rows, columns);
PrintMatrix(res); // ДО
Console.WriteLine("Результат: ");
SquareElements(res); // Возводим в квадрат
PrintMatrix(res); // ПОСЛЕ
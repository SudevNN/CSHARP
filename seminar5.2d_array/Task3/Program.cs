// Задание 3. Совместная работа
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.

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

double[] GetArrayWithMeans(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)]; // Размер массива = количество строк в матрице 
    for (int i = 0; i < matrix.GetLength(0); i++) //  стр 
    {
        double currentSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)// столб
        {
            currentSum += matrix[i, j];
            // currentSum = currentSum + matrix[i, j];
        }
        double currentMean = Math.Round(currentSum / matrix.GetLength(1), 2);
        // Math.Round(1.234, 2) => 1.23
        means[i] = currentMean;
    }
    return means;
}

// Вызовы функции
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] res = FillMatrix(rows, columns);
PrintMatrix(res); // ДО
Console.WriteLine($"Результат: [ {string.Join("; ", GetArrayWithMeans(res))} ] ");
// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// Доп. задание: массив чаров создать рандомно с 
// помощью метода next.
// Пример:
// a b c => “abcdef”
// d e f

char[,] FillMatrix(int rows, int cols)
{
    char[,] matrix = new char[rows, cols];
    Random rnd = new Random();
    // Матрица, размер: rows стр и cols столбцов
    for (int i = 0; i < rows; i++) // i < matrix.GetLength(0), стр
    {
        // j, m, k
        for (int j = 0; j < cols; j++)// j < matrix.GetLength(1), столб
        {
            matrix[i, j] = Convert.ToChar(rnd.Next('a', 'a' + 26)); 
        }
    }
    return matrix;
}

void PrintMatrix(char[,] matr)
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

string UnionCharElements(char[,] matr)
{
    string arrToStr = string.Empty;
    for (int i = 0; i < matr.GetLength(0); i++) //  стр 
    {
        for (int j = 0; j < matr.GetLength(1); j++)// столб
        {
            arrToStr += matr[i, j];
        }
    }
    return arrToStr;
}

// Уточняем размер матрицы:
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Наполняем массив случайными числами
char[,] createMatrix = FillMatrix(rows, columns);
PrintMatrix(createMatrix); // Массив ДО
Console.WriteLine("Результат: ");
string matrToStr = UnionCharElements(createMatrix);
Console.WriteLine(matrToStr); // Строка ПОСЛЕ
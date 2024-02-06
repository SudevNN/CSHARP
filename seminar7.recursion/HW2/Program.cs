// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// Пример
// m = 2, n = 3 -> A(m,n) = 29

int AckNumber(int m, int n)
{
    if (m == 0) return n += 1;
    else if (n == 0) return AckNumber(m - 1, 1);
    else return AckNumber(m - 1, AckNumber(m, n - 1));
}

Console.Write("Введите неотрицательное целое число M: ");
int natPositiveNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное целое число N: ");
int natPositiveNumberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана = {AckNumber(natPositiveNumberM, natPositiveNumberN)}");